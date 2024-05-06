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
    public partial class AgregarProducto : Form
    {


        Operaciones operacion = new Operaciones();
        ErrorProvider errorP = new ErrorProvider();
        public AgregarProducto()
        {
            InitializeComponent();
        }

        private void AgregarProducto_Load(object sender, EventArgs e)
        {

        }

        private void guardar_Click(object sender, EventArgs e)
        {
            if (VerificarTextBoxLlenos())
            {
                operacion.producto = textProducto.Text;
                operacion.precio_costo = float.Parse(textPC.Text);
                operacion.precio_operativo = float.Parse(textPO.Text);
                operacion.precio_venta = float.Parse(textPV.Text);
                operacion.porcentaje_ganancia = float.Parse(textPG.Text);
                operacion.utilidad = float.Parse(textUtilidad.Text);

                operacion.agregarProducto();
                MessageBox.Show("Se agrego el producto");
                this.Close();

            }
            else
            {
                MessageBox.Show("Por favor, debe llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private bool VerificarTextBoxLlenos()
        {

            if (!string.IsNullOrWhiteSpace(textProducto.Text) &&
                !string.IsNullOrWhiteSpace(textPC.Text) &&
                !string.IsNullOrWhiteSpace(textPO.Text) &&
                !string.IsNullOrWhiteSpace(textPV.Text) &&
                !string.IsNullOrWhiteSpace(textPG.Text) &&
                !string.IsNullOrWhiteSpace(textUtilidad.Text)
            )
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        
        private void textPC_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = operacion.soloNumeros(e);
            if (!valida)
            {
                errorP.SetError(textPC, "Solo números");
            }
            else
            {
                errorP.Clear();
            }
        }
        

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                errorP.Clear();
                textPC.Focus();
                e.Handled = true;
            }
        }

        private void textPC_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                errorP.SetError(textPC, "Solo se permiten números");
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
                textPO.Focus();
                e.Handled = true;
            }
        }

        private void textPO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                errorP.SetError(textPO, "Solo se permiten números");
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
                textPV.Focus();
                e.Handled = true;
            }
        }

        private void textPV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                errorP.SetError(textPV, "Solo se permiten números");
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
                guardar.Focus();
                e.Handled = true;
            }
        }

        public void calcUtilidad()
        {
            float pv = 0;
            float po = 0;
            float uti = 0;

            if (!string.IsNullOrWhiteSpace(textPO.Text))
            {
                
                po = float.Parse(textPO.Text);
            }
            if (!string.IsNullOrWhiteSpace(textPV.Text))
            {
                pv = float.Parse(textPV.Text);
            }

            uti = pv - po;

            textUtilidad.Text = uti.ToString();

            float pg = uti / po;
            textPG.Text = pg.ToString("0.00");
        }

        private void textPV_TextChanged(object sender, EventArgs e)
        {
            calcUtilidad();
        }

        private void textPO_TextChanged(object sender, EventArgs e)
        {
            calcUtilidad();
        }
    }
}
