using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SimuladorMS1
{
    public partial class AgregarGasto : Form
    {

        Operaciones operacion = new Operaciones();
        ErrorProvider errorP = new ErrorProvider();
        List<Tuple<string, int>> items = new List<Tuple<string, int>>
        {
            new Tuple<string, int>("Fijo", 1),
            new Tuple<string, int>("Variable", 2),

        };

        public AgregarGasto()
        {
            InitializeComponent();
            setItems();
        }

        public void setItems()
        {
            // Asigna los elementos al ComboBox
            cmbTipos.DisplayMember = "Item1"; // Establece el texto visible
            cmbTipos.ValueMember = "Item2"; // Establece el valor asociado
            cmbTipos.DataSource = items; // Asigna la lista de elementos al ComboBox
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            if (VerificarTextBoxLlenos())
            {
                
                operacion.nombreGasto = textGasto.Text;
                operacion.monto = float.Parse(textMonto.Text);
                operacion.tipoGasto = cmbTipos.Text;
                

                operacion.agregarGasto();
                MessageBox.Show("Se agrego el gasto");
                this.Close();

            }
            else
            {
                MessageBox.Show("Por favor, debe llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool VerificarTextBoxLlenos()
        {

            if (!string.IsNullOrWhiteSpace(textGasto.Text) &&
                !string.IsNullOrWhiteSpace(textMonto.Text) 
            )
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        private void textGasto_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                errorP.Clear();
                textMonto.Focus();
                e.Handled = true;
            }
        }

        private void textMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                errorP.SetError(textMonto, "Solo se permiten números");
            }

            // Verifica si el punto decimal ya se ha ingresado
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                errorP.Clear();
                cmbTipos.Focus();
                e.Handled = true;
            }
        }
    }
}
