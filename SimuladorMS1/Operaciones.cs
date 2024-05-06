using SimuladorMS1.bdSimuladorDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorMS1
{
    internal class Operaciones
    {
        Random random = new Random();
        getProductByIdTableAdapter getProduct = new getProductByIdTableAdapter();
        getEscenarioTableAdapter getScenery = new getEscenarioTableAdapter();
        getHoraTableAdapter getHour = new getHoraTableAdapter();
        getProductCustomerTableAdapter getProductCustomer = new getProductCustomerTableAdapter();
        QueriesTableAdapter getQueries = new QueriesTableAdapter();

        public string producto { get; set; }
        public float precio_costo { get; set; }
        public float precio_operativo { get; set; }
        public float precio_venta { get; set; }
        public float porcentaje_ganancia { get; set; }
        public float utilidad { get; set; }
        public string nombreGasto { get; set; }
        public float monto { get; set; }
        public string tipoGasto { get; set; }


        // Obtener los registros de un escenario
        public DataTable getEscenario(int escenario, int servicio)
        {
            DataTable dataTable = getScenery.GetData(escenario, servicio); 
            return dataTable;
        }

        // Obtener los registros de una hora
        public DataTable getHora(int escenario, int hora, int clientes)
        {
            DataTable dataTable = getHour.GetData(escenario, hora, clientes); 

            return dataTable;
        }

        // Obtener los productos de un cliente
        //public DataTable getProductoCliente(int escenario, int hora, int idCliente)
        //{
        //    DataTable dataTable = getProductCustomer.GetData(escenario, hora, idCliente);
        //    return dataTable;
        //}

        public DataTable getProductoCliente(int escenario, int hora, int idCliente)
        {
            DataTable dataTable = getProductCustomer.GetData(escenario, hora, idCliente);

            // Crear un diccionario para realizar un seguimiento de la última fila de cada producto
            Dictionary<string, DataRow> lastProductRows = new Dictionary<string, DataRow>();

            Dictionary<string, int> productosContados = new Dictionary<string, int>();

            // Agregar una nueva columna "Cantidad" al DataTable
            dataTable.Columns.Add("Cantidad", typeof(int)).SetOrdinal(2); // Insertar después de la columna Producto

            // Agregar una nueva columna "No." al DataTable para enumerar los registros
            dataTable.Columns.Add("No.", typeof(int)).SetOrdinal(0);

            // Iterar sobre los registros del DataTable para realizar un seguimiento de las filas únicas de cada producto
            foreach (DataRow row in dataTable.Rows)
            {
                string producto = row["Producto"].ToString();

                // Si el producto ya existe en el diccionario, actualizar la fila con el último registro
                if (lastProductRows.ContainsKey(producto))
                {
                    lastProductRows[producto] = row;
                }
                else
                {
                    // Agregar el producto al diccionario si no existe
                    lastProductRows.Add(producto, row);
                }

                // Verificar si el producto ya se ha encontrado antes
                if (productosContados.ContainsKey(producto))
                {
                    // Incrementar la cantidad si el producto ya existe
                    productosContados[producto]++;
                }
                else
                {
                    // Agregar el producto al diccionario y establecer la cantidad en 1 si es la primera vez que se encuentra
                    productosContados.Add(producto, 1);
                }

                // Establecer la cantidad en la columna "Cantidad"
                row["Cantidad"] = productosContados[producto];
            }

            // Contador para el número de registros
            int numeroRegistro = 1;

            // Agregar las últimas filas de cada producto al DataTable y enumerarlas
            foreach (var kvp in lastProductRows)
            {
                // Establecer el número de registro en la columna "No."
                kvp.Value["No."] = numeroRegistro++;

            }

            // Crear un nuevo DataTable para almacenar solo las últimas filas de cada producto
            DataTable uniqueProductTable = dataTable.Clone();

            // Agregar las últimas filas de cada producto al nuevo DataTable
            foreach (var kvp in lastProductRows)
            {
                uniqueProductTable.ImportRow(kvp.Value);
            }

            return uniqueProductTable;
        }


        // Obtener los gastos totales
        public float getGastoTotal()
        {
            float total = (float)getQueries.getMontoTotal();

            return total;
        }

        // Función que genera un número aleatorio y lo retorna
        public int setNumber(int min, int max)
        {

            int numeroAleatorio = random.Next(min, max + 1);

            return numeroAleatorio;
        }

        // Obtener los registros de un producto
        public DataTable getProducto(int id)
        {
            //DataTable dataTable = new DataTable();
            DataTable dataTable = getProduct.GetData(id); //Se busca el producto con el id
            return dataTable;
        }

        // Función para generar escenarios
        public void crearEscenarios(int horas, int clientes, int productos)
        {
            getQueries.InsertarEscenarios(horas, clientes, productos);
        }


        // Función para eliminar escenarios
        public void eliminarEscenarios()
        {
            getQueries.pEliminarEscenarios();
        }

        public void agregarProducto()
        {
            getQueries.pCrearProducto(producto, precio_costo, precio_operativo, precio_venta, porcentaje_ganancia, utilidad);
        }

        public void agregarGasto()
        {
            getQueries.pCrearGasto(nombreGasto, monto, tipoGasto);
        }
        public bool soloNumeros(KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else
            {
                e.Handled = true;
                return false;
            }
        }

        // Mostrar mensajes de error
        public DialogResult MostrarMensajeError(string mensaje)
        {
            return MessageBox.Show(mensaje, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }
    }
}
