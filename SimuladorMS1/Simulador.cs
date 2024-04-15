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
    public partial class Simulador : Form
    {
        Operaciones operaciones = new Operaciones();
        Formulas formulas = new Formulas();
        ErrorProvider errorP = new ErrorProvider();
        // Tablas temporales
        DataTable tableGeneral = new DataTable();
        DataTable tableHoras = new DataTable();
        DataTable tableClientes = new DataTable();

        public List<int> listGeneral = new List<int>(); // Lista para almacenar los valores generados
        public List<(int clientId, int clientValue)> listClient = new List<(int, int)>();

        public Dictionary<int, List<int>> linkedValues = new Dictionary<int, List<int>>();

        List<(int, float, float)> listaTotales = new List<(int, float, float)>();

        int ide;

        int media, lambda, horas, productosC;
        public Simulador()
        {
            InitializeComponent();
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            if (VerificarTextBoxLlenos())
            {
                getDataForm();
                fillListGeneral();
                fillListClient();
                FillLinkedValues();
                fillGeneralTable(horas, media);
                // Imprimir registros de listGeneral
                Console.WriteLine("Registros de listGeneral:");
                foreach (int value in listGeneral)
                {
                    Console.WriteLine(value);
                }

                // Imprimir registros de listClient
                Console.WriteLine("\nRegistros de listClient:");
                foreach ((int clientId, int clientValue) in listClient)
                {
                    Console.WriteLine($"ClientId: {clientId}, ClientValue: {clientValue}");
                }

                // Imprimir registros de linkedValues
                Console.WriteLine("\nRegistros de linkedValues:");
                foreach (var kvp in linkedValues)
                {
                    Console.WriteLine($"Key: {kvp.Key}");
                    Console.WriteLine("Values:");
                    foreach (int value in kvp.Value)
                    {
                        Console.WriteLine(value);
                    }
                }


            }
            else
            {
                operaciones.MostrarMensajeError("Debe llenar todos los campos requeridos");
            }
            
        }

        public void fillListGeneral()
        {
            // Limpiar la lista antes de llenarla
            listGeneral.Clear();

            // Iterar desde 1 hasta el valor de txtHoras
            for (int i = 1; i <= horas; i++)
            {
                // Generar un número aleatorio y agregarlo a la lista junto con un identificador único
                int randomNumber = operaciones.setNumber(1, media); 
                listGeneral.Add((randomNumber));
            }
        }

        public void fillListClient()
        {
            // Limpiar la lista antes de llenarla
            listClient.Clear();

            int clientIdCounter = 0; // Contador para generar identificadores únicos

            foreach (int general in listGeneral)
            {
                for (int i = 1; i <= general; i++)
                {
                    // Generar un número aleatorio y agregarlo a la lista junto con un identificador único
                    int randomNumber = operaciones.setNumber(1, productosC);
                    int clientId = ++clientIdCounter; // Incrementar el contador para obtener un identificador único
                    listClient.Add((clientId, randomNumber));
                }
            }
        }


        private void FillLinkedValues()
        {
            // Limpiar el diccionario antes de llenarlo
            linkedValues.Clear();

            // Iterar sobre los valores de listClient
            foreach ((int clientId, int clientValue) in listClient)
            {
                // Generar una lista de valores aleatorios para cada valor de listClient
                List<int> randomValues = new List<int>();

                // Usar el valor de clientValue como la cantidad de valores aleatorios a generar
                for (int i = 0; i < clientValue; i++)
                {
                    int randomNumber = operaciones.setNumber(1, 62); 
                    randomValues.Add(randomNumber);
                    
                }

                // Agregar la lista de valores aleatorios al diccionario, vinculada al valor de listClient
                linkedValues.Add(clientId, randomValues);
            }
        }
        private void dataGeneral_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si la celda seleccionada es válida y es λ
            if (e.ColumnIndex == dataGeneral.Columns["λ"].Index && e.RowIndex >= 0)
            {
                // Obtener el valor de la celda seleccionada
                int numero = Convert.ToInt32(dataGeneral.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);

                //fillHoursTable(numero);
                fillHoursTable2(numero);
            }

        }

        public void getDataForm()
        {
            //lambda = Convert.ToInt32(txtLambda.Text);
            media = Convert.ToInt32(txtProductosCliente.Text);
            horas = Convert.ToInt32(txtHoras.Text);
            productosC = Convert.ToInt32(txtMedia.Text);
        }

        private void txtMedia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bloquea la tecla presionada
                errorP.SetError(txtMedia, "Solo se permiten números enteros");
            }
            else
            {
                errorP.Clear();
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                errorP.Clear();
                txtProductosCliente.Focus();
                e.Handled = true;

            }
        }

        private void txtProductosCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bloquea la tecla presionada
                errorP.SetError(txtProductosCliente, "Solo se permiten números enteros");
            }
            else
            {
                errorP.Clear();
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                errorP.Clear();
                txtHoras.Focus();
                e.Handled = true;

            }
        }

        private void txtHoras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bloquea la tecla presionada
                errorP.SetError(txtHoras, "Solo se permiten números enteros");
            }
            else
            {
                errorP.Clear();
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                errorP.Clear();
                btnSimular.Focus();
                e.Handled = true;

            }
        }

        public void fillGeneralTable(int horas, int med)
        {
            // Limpiar la tabla antes de agregar nuevos datos
            tableGeneral.Rows.Clear();

            // Asegurarse de que las columnas de la tabla estén definidas
            if (tableGeneral.Columns.Count == 0)
            {
                tableGeneral.Columns.Add("Hora", typeof(int));
                tableGeneral.Columns.Add("λ", typeof(int));
                tableGeneral.Columns.Add("µ", typeof(int));
                tableGeneral.Columns.Add("Ingreso/Hora", typeof(int));

            }

            // Calcular y agregar los datos a la tabla
            for (int i = 1; i <= horas; i++)
            {
                //lambda = operaciones.setNumber(0, med);

                // Obtener el valor de clientValue para la hora actual
                int lamb = listGeneral[i - 1]; 

                // Agregar fila a la tabla
                tableGeneral.Rows.Add(i, lamb, med, 1);
            }

            // Asignar la tabla como origen de datos del DataGridView
            dataGeneral.DataSource = tableGeneral;
        }


        
        private void dgvDetallesHora_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si la celda seleccionada es válida y es Productos
            if (e.ColumnIndex == dgvDetallesHora.Columns["Productos"].Index && e.RowIndex >= 0)
            {
                // Obtener el valor de la celda seleccionada
                int numero = Convert.ToInt32(dgvDetallesHora.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);

                fillCustomerTable(numero);
                
            }
        }

       
        public void fillHoursTable(int num)
        {
            frmHoras frmHoras = new frmHoras();
            // Limpiar el DataGridView antes de agregar nuevos datos
            frmHoras.dataHoras.Rows.Clear();

            // Define las columnas del DataGridView si aún no están definidas
            if (frmHoras.dataHoras.Columns.Count == 0)
            {
                frmHoras.dataHoras.Columns.Add("No.", "No.");
                frmHoras.dataHoras.Columns.Add("Productos", "Productos");
                frmHoras.dataHoras.Columns.Add("Total Costo", "Total Costo");
                frmHoras.dataHoras.Columns.Add("Total Venta", "Total Venta");
                frmHoras.dataHoras.Columns.Add("Utilidad", "Utilidad");
            }

            // Calcular y agregar los datos al DataGridView
            for (int i = 1; i <= num; i++)
            {
                // Obtener el producto correspondiente al cliente actual desde listClient
                int clientId = i; // El id de la celda es igual al índice + 1
                int clientValue = listClient[clientId - 1].clientValue; // Restar 1 para ajustar el índice

                // Agregar fila al DataGridView con los datos obtenidos
                frmHoras.dataHoras.Rows.Add(i, clientValue, 1.2, 3, 4);
            }

            frmHoras.ShowDialog();

        }

        public void fillHoursTable2(int num)
        {
            
            // Limpiar el DataGridView antes de agregar nuevos datos
            dgvDetallesHora.Rows.Clear();

            // Define las columnas del DataGridView si aún no están definidas
            if (dgvDetallesHora.Columns.Count == 0)
            {
                dgvDetallesHora.Columns.Add("No.", "No.");
                dgvDetallesHora.Columns.Add("Productos", "Productos");
                dgvDetallesHora.Columns.Add("Total Costo", "Total Costo");
                dgvDetallesHora.Columns.Add("Total Venta", "Total Venta");
                dgvDetallesHora.Columns.Add("Utilidad", "Utilidad");
            }

            // Calcular y agregar los datos al DataGridView
            for (int i = 1; i <= num; i++)
            {
                // Obtener el producto correspondiente al cliente actual desde listClient
                int clientId = i; // El id de la celda es igual al índice + 1
                int clientValue = listClient[clientId - 1].clientValue; // Restar 1 para ajustar el índice

                // Agregar fila al DataGridView con los datos obtenidos
                dgvDetallesHora.Rows.Add(i, clientValue, 1.2, 3, 4);
            }

            

        }
        //public int getSelectedClientIdFromDetallesHora()
        //{
        //    // Obtener la instancia actual del formulario frmHoras
        //    frmHoras frmHoras = Application.OpenForms.OfType<frmHoras>().FirstOrDefault();

        //    // Verificar si se encontró una instancia válida de frmHoras
        //    if (frmHoras != null)
        //    {
        //        // Obtener la fila seleccionada del DataGridView en frmHoras
        //        int selectedRow = frmHoras.dataHoras.CurrentRow.Index;

        //        // Obtener el clientId de la fila seleccionada
        //        int clientId = Convert.ToInt32(frmHoras.dataHoras.Rows[selectedRow].Cells[0].Value);

        //        return clientId;
        //    }
        //    else
        //    {
        //        // Si no se encontró una instancia válida de frmHoras, devolver un valor predeterminado o manejar el caso según sea necesario
        //        // Aquí devolvemos -1 como valor predeterminado
        //        return -1;
        //    }
        //}

        public int getSelectedClientIdFromDetallesHora()
        {
            frmHoras frmHoras = new frmHoras();

            int selectedRow = frmHoras.dataHoras.CurrentRow.Index;
            int clientId = Convert.ToInt32(frmHoras.dataHoras.Rows[selectedRow].Cells[0].Value);
            return clientId;

        }

        public int getClientId()
        {
            int selectedRow = dgvDetallesHora.CurrentRow.Index;
            int clientId = Convert.ToInt32(dgvDetallesHora.Rows[selectedRow].Cells[0].Value);
            return clientId;
            
        }
        public void fillCustomerTable(int num)
        {
            //frmClientes frmClientes = new frmClientes();
            // Limpiar el DataGridView antes de agregar nuevos datos
            dgvDetallesProducto.Rows.Clear();

            // Define las columnas del DataGridView si aún no están definidas
            if (dgvDetallesProducto.Columns.Count == 0)
            {
                dgvDetallesProducto.Columns.Add("No", "No");
                dgvDetallesProducto.Columns.Add("Producto", "Producto");
                dgvDetallesProducto.Columns.Add("Costo", "Costo");
                dgvDetallesProducto.Columns.Add("Venta", "Venta");
                dgvDetallesProducto.Columns.Add("Utilidad", "Utilidad");
            }

            // Obtener el clientId seleccionado en dgvDetallesHora
            int clientId = getClientId();
            
            // Calcular y agregar los datos a la serie vinculados al clientId seleccionado
            if (linkedValues.ContainsKey(clientId))
            {
                List<int> products = linkedValues[clientId];
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
                        dgvDetallesProducto.Rows.Add(i + 1, nombre, precioCosto, precioVenta, utilidad);
                    }
                    else
                    {
                        // Si no se encontró el producto, agregar valores predeterminados
                        dgvDetallesProducto.Rows.Add(i + 1, "No Disponible", "No Disponible", "No Disponible", "No Disponible");
                    }
                }
            }

            //frmClientes.ShowDialog();
        }




        public bool VerificarTextBoxLlenos()
        {

            if (!string.IsNullOrWhiteSpace(txtMedia.Text) &&
                !string.IsNullOrWhiteSpace(txtProductosCliente.Text) &&
                !string.IsNullOrWhiteSpace(txtHoras.Text)
            )
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
