using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SimuladorMS1
{
    public partial class Simulador : Form
    {
        Operaciones operaciones = new Operaciones();
        Formulas formulas = new Formulas();
        ErrorProvider errorP = new ErrorProvider();

        int ide;
        int servi = 4; /*escen = 1;*/
        int media, lambda, horas, productosC;
        public Simulador()
        {
            InitializeComponent();
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            if (VerificarTextBoxLlenos())
            {
                operaciones.eliminarEscenarios();
                getDataForm();
                operaciones.crearEscenarios(horas, media, productosC);

                // Mostrar la barra de progreso
                progressBar.Visible = true;
                progressBar.Maximum = 5; // 5 segundos
                progressBar.Value = 0;

                // Habilitar el temporizador para actualizar la barra de progreso
                timerProgreso.Enabled = true;

                // Esperar 5 segundos antes de continuar
                timerProgreso.Start();
            }
            else
            {
                operaciones.MostrarMensajeError("Debe llenar todos los campos requeridos");
            }
            
        }

        private void dataGeneral_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si la celda clickeada está dentro de los límites del DataGridView
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                frmHoras frmHoras = new frmHoras();
                
                // Obtener el valor de la primera columna (índice 0)
                int hora = Convert.ToInt32(dataGeneral.Rows[e.RowIndex].Cells[0].Value);
                Formulas.idHora = hora;
                // Obtener el valor de la segunda columna (índice 1)
                int clientes = Convert.ToInt32(dataGeneral.Rows[e.RowIndex].Cells[1].Value);

                frmHoras.dataHoras.DataSource = operaciones.getHora(Formulas.escenario, hora, clientes);

                frmHoras.ShowDialog();
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




        public void getEscenario(int escenario, int servicio)
        {
            DataTable escenarioTable = operaciones.getEscenario(escenario, servicio);

            dataGeneral.DataSource = escenarioTable;
        }

        private void timerProgreso_Tick_1(object sender, EventArgs e)
        {
            // Incrementar el valor de la barra de progreso
            progressBar.Value++;

            // Si han pasado 5 segundos, detener el temporizador y ocultar la barra de progreso
            if (progressBar.Value >= progressBar.Maximum)
            {
                timerProgreso.Stop();
                progressBar.Visible = false;

                // Realizar las operaciones después de que termine la barra de progreso
                Formulas.escenario = 1;
                getEscenario(Formulas.escenario, 4);
            }
        }

        public void getHora(int escenario, int hora, int clientes)
        {
            DataTable escenarioTable = operaciones.getHora(escenario, hora, clientes);

            dataGeneral.DataSource = escenarioTable;
        }

        public void getProductoCliente(int escenario, int hora, int idCliente)
        {
            DataTable escenarioTable = operaciones.getHora(escenario, hora, idCliente);

            dataGeneral.DataSource = escenarioTable;
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
