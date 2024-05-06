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

        public AgregarGasto()
        {
            InitializeComponent();
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
                operacion.tipoGasto = textTipo.Text;
                

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
                !string.IsNullOrWhiteSpace(textMonto.Text) &&
            !string.IsNullOrWhiteSpace(textTipo.Text)
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
