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
        Formulas formulas = new Formulas();
        public frmHoras()
        {
            InitializeComponent();

            dataHoras.DefaultCellStyle.Font = new Font("Arial", 12);
            // Cambiar el color de fondo de la primera fila
            dataHoras.Rows[0].DefaultCellStyle.BackColor = Color.LightBlue;
        }

        // Evento al presionar una celda de la tabla Hora
        private void dataHoras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si la celda clickeada está dentro de los límites del DataGridView
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                frmClientes frmClientes = new frmClientes();

                // Obtener el valor de la primera columna (índice 0)
                int idCliente = Convert.ToInt32(dataHoras.Rows[e.RowIndex].Cells[0].Value);
                Formulas.idCliente = idCliente;

                frmClientes.dataClientes.DataSource = operaciones.getProductoCliente(Formulas.escenario, Formulas.idHora, idCliente);
                frmClientes.Text = "Cliente " + idCliente;

                frmClientes.ShowDialog();
            }


        }
    }
}
