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
        }
        public int getSelectedClientIdFromDetallesHora()
        {
            // Obtener la instancia actual del formulario frmHoras
            //frmHoras frmHoras = Application.OpenForms.OfType<frmHoras>().FirstOrDefault();
            int selectedRow = dataHoras.CurrentRow.Index;
            int clientId = Convert.ToInt32(dataHoras.Rows[selectedRow].Cells[0].Value);
            return clientId;
            

        }

       
        private void dataHoras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si la celda clickeada está dentro de los límites del DataGridView
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                frmHoras frmHoras = new frmHoras();

                // Obtener el valor de la primera columna (índice 0)
                int idCliente = Convert.ToInt32(dataHoras.Rows[e.RowIndex].Cells[0].Value);

                // Obtener el valor de la segunda columna (índice 1)
                //int hora = Formulas.idHora;

                frmHoras.dataHoras.DataSource = operaciones.getProductoCliente(Formulas.escenario, Formulas.idHora, idCliente);

                frmHoras.ShowDialog();
            }


        }
    }
}
