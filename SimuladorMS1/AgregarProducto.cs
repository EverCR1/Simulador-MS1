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

        /*
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
        */

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
