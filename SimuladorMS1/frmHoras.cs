using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorMS1
{
    public partial class frmHoras : Form
    {
        Simulador simulador = new Simulador();
        Operaciones operaciones = new Operaciones();
        public frmHoras()
        {
            InitializeComponent();
        }
        public int getSelectedClientIdFromDetallesHora()
        {
            // Obtener la instancia actual del formulario frmHoras
            //frmHoras frmHoras = Application.OpenForms.OfType<frmHoras>().FirstOrDefault();
            int selectedRow = dataHoras.CurrentRow.Index;
            int clientId = Convert.ToInt32(dataHoras.Rows[selectedRow].Cells[0].Value);
            return clientId;
            

        }

        public void fillCustomerTable(int num)
        {
            frmClientes frmClientes = new frmClientes();
            // Limpiar el DataGridView antes de agregar nuevos datos
            frmClientes.dataClientes.Rows.Clear();

            // Define las columnas del DataGridView si aún no están definidas
            if (frmClientes.dataClientes.Columns.Count == 0)
            {
                frmClientes.dataClientes.Columns.Add("No", "No");
                frmClientes.dataClientes.Columns.Add("Producto", "Producto");
                frmClientes.dataClientes.Columns.Add("Costo", "Costo");
                frmClientes.dataClientes.Columns.Add("Venta", "Venta");
                frmClientes.dataClientes.Columns.Add("Utilidad", "Utilidad");
            }

            // Obtener el clientId seleccionado en dgvDetallesHora
            int clientId = getSelectedClientIdFromDetallesHora();
            Console.WriteLine(clientId);

            // Calcular y agregar los datos a la serie vinculados al clientId seleccionado
            if (simulador.linkedValues.ContainsKey(clientId))
            {
                Console.WriteLine("SSSS");
                List<int> products = simulador.linkedValues[clientId];
                for (int i = 0; i < products.Count; i++)
                {
                    int productId = products[i];
                    // Obtener los datos del producto según el productId
                    DataTable productoData = operaciones.getProducto(productId);
                    if (productoData.Rows.Count > 0)
                    {
                        string nombre = Convert.ToString(productoData.Rows[0]["producto"]);
                        float precioCosto = Convert.ToSingle(productoData.Rows[0]["precio_costo"]);
                        float precioVenta = Convert.ToSingle(productoData.Rows[0]["precio_venta"]);
                        float utilidad = Convert.ToSingle(productoData.Rows[0]["utilidad"]);

                        // Agregar fila al DataGridView con los datos obtenidos
                        frmClientes.dataClientes.Rows.Add(i + 1, nombre, precioCosto, precioVenta, utilidad);
                        
                    }
                    else
                    {
                        // Si no se encontró el producto, agregar valores predeterminados
                        frmClientes.dataClientes.Rows.Add(i + 1, "No Disponible", "No Disponible", "No Disponible", "No Disponible");
                    }
                    Console.WriteLine(productoData);
                }
                
            }
            frmClientes.ShowDialog();

        }
        private void dataHoras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si la celda seleccionada es válida y es Productos
            if (e.ColumnIndex == dataHoras.Columns["Productos"].Index && e.RowIndex >= 0)
            {
                // Obtener el valor de la celda seleccionada
                int numero = Convert.ToInt32(dataHoras.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);

                fillCustomerTable(numero);

            }
            //frmClientes frmClientes = new frmClientes();
            //frmClientes.dataClientes.DataSource = simulador.dgvDetallesProducto;
            //frmClientes.ShowDialog();


        }
    }
}
