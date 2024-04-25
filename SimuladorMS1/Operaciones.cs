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
        public DataTable getProductoCliente(int escenario, int hora, int idCliente)
        {
            DataTable dataTable = getProductCustomer.GetData(escenario, hora, idCliente);
            return dataTable;
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

        // Mostrar mensajes de error
        public DialogResult MostrarMensajeError(string mensaje)
        {
            return MessageBox.Show(mensaje, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }
    }
}
