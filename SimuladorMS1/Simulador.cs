using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SimuladorMS1
{
    public partial class Simulador : Form
    {
        Operaciones operaciones = new Operaciones();
        Formulas formulas = new Formulas();
        ErrorProvider errorP = new ErrorProvider();

        public Simulador()
        {
            InitializeComponent();
        }

        // Acciones al presionar el botón Simular
        private void btnSimular_Click(object sender, EventArgs e)
        {
            if (VerificarTextBoxLlenos())
            {
                operaciones.eliminarEscenarios();
                getDataForm();
                operaciones.crearEscenarios(Formulas.horas, Formulas.mediaClientes, Formulas.mediaProductos);
                Formulas.escenario = 1;
                Formulas.simulado = true;

                // Mostrar la barra de progreso
                progressBar.Visible = true;
                progressBar.Maximum = 4; // 4 segundos
                progressBar.Value = 1;

                // Habilitar el temporizador para actualizar la barra de progreso
                timerProgreso.Enabled = true;

                // Esperar 3 segundos antes de continuar
                timerProgreso.Start();
            }
            else
            {
                operaciones.MostrarMensajeError("Debe llenar todos los campos requeridos");
            }
            
        }

        public void isSimulado()
        {
            if (Formulas.simulado)
            {
                showScenary();
                string esc = Formulas.escenario.ToString();
                labelEscenario.Text = "Escenario " + esc;
                getEscenario(Formulas.escenario, Formulas.tiempoServicio);
                btnMM1.Visible = true;
                btnGraficas.Visible = true;

                getGastoHora();
                
                txtMedia.Text = Formulas.mediaClientes.ToString();
                txtServicio.Text = Formulas.tiempoServicio.ToString();
                txtProductosCliente.Text = Formulas.mediaProductos.ToString();
                txtHoras.Text = Formulas.horas.ToString(); 
  
            }
            else
            {

            }
        }

        // Evento al presionar una celda de la tabla General
        private void dataGeneral_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si la celda clickeada está dentro de los límites del DataGridView
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                frmHoras frmHoras = new frmHoras();
                
                // Obtener el valor de la primera columna (índice 0)
                int idHora = Convert.ToInt32(dataGeneral.Rows[e.RowIndex].Cells[0].Value);
                Formulas.idHora = idHora;

                // Obtener el valor de la segunda columna (índice 1)
                int clientes = Convert.ToInt32(dataGeneral.Rows[e.RowIndex].Cells[1].Value);

                frmHoras.dataHoras.DataSource = operaciones.getHora(Formulas.escenario, idHora, clientes);
                frmHoras.Text = "Hora " + idHora;

                frmHoras.ShowDialog();
            }

        }

        // Obtener los valores del formulario
        public void getDataForm()
        {
            Formulas.mediaClientes = Convert.ToInt32(txtMedia.Text);
            Formulas.tiempoServicio = Convert.ToInt32(txtServicio.Text);
            Formulas.horas = Convert.ToInt32(txtHoras.Text);
            Formulas.mediaProductos = Convert.ToInt32(txtProductosCliente.Text);

            Formulas.λ = Convert.ToDouble(txtMedia.Text);
            Formulas.µ = Convert.ToDouble(txtServicio.Text);

        }

        // Eventos al ingresar valores al formulario
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
                txtServicio.Focus();
                e.Handled = true;

            }
        }

        private void txtServicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bloquea la tecla presionada
                errorP.SetError(txtServicio, "Solo se permiten números enteros");
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

        // Generar la barra de carga al simular
        private void timerProgreso_Tick_1(object sender, EventArgs e)
        {
            // Incrementar el valor de la barra de progreso
            progressBar.Value++;

            // Si han pasado 4 segundos, detener el temporizador y ocultar la barra de progreso
            if (progressBar.Value >= progressBar.Maximum)
            {
                timerProgreso.Stop();
                progressBar.Visible = false;

                showScenary();

                // Realizar las operaciones después de que termine la barra de progreso
                string esc = Formulas.escenario.ToString();
                labelEscenario.Text = "Escenario " + esc;
                getEscenario(Formulas.escenario, Formulas.tiempoServicio);
                btnMM1.Visible = true;
                btnGraficas.Visible = true;

                getGastoHora();
                
            }
        }

        // Evento al presionar el botón "Anterior"
        private void btnPrev_Click(object sender, EventArgs e)
        {
            
            if(Formulas.escenario == 1)
            {

            }
            else
            {
                Formulas.escenario = Formulas.escenario - 1;
                string esc = Formulas.escenario.ToString();
                labelEscenario.Text = "Escenario " + esc;
                getEscenario(Formulas.escenario, Formulas.tiempoServicio);
            }
            
        }

        // Evento al presionar el botón "Siguiente"
        private void btnNext_Click(object sender, EventArgs e)
        {
            
            if(Formulas.escenario == 3)
            {

            }
            else
            {
                Formulas.escenario = Formulas.escenario + 1;
                string esc = Formulas.escenario.ToString();
                labelEscenario.Text = "Escenario " + esc;
                getEscenario(Formulas.escenario, Formulas.tiempoServicio);
            }
            
        }

        // Obtener el escenario n
        public void getEscenario(int escenario, int servicio)
        {
            DataTable escenarioTable = operaciones.getEscenario(escenario, servicio);

            dataGeneral.DataSource = escenarioTable;

            cumpleGanancia(); // Verificar si la ganancia por hora es mayor al gasto por hora
        }

        // Resaltar la celda Ganancia para cada hora
        public void cumpleGanancia()
        {
            float totalGastos = operaciones.getGastoTotal();
            float gastoHora = totalGastos / 30 / 8;

            // Iterar sobre las filas del DataGridView
            foreach (DataGridViewRow row in dataGeneral.Rows)
            {
                // Obtener el valor de la celda en la columna 4 (índice 3)
                float valorCelda;
                if (float.TryParse(row.Cells[3].Value?.ToString(), out valorCelda))
                {
                    // Resaltar la celda según el valor
                    if (valorCelda >= gastoHora)
                    {
                        row.Cells[3].Style.BackColor = Color.LightGreen; // Verde si cumple la ganancia
                    }
                    else
                    {
                        row.Cells[3].Style.BackColor = Color.LightCoral; // Rojo si no cumple la ganancia
                    }
                }
            }
        }

        // Validar que no existan campos nulos
        public bool VerificarTextBoxLlenos()
        {

            if (!string.IsNullOrWhiteSpace(txtMedia.Text) &&
                !string.IsNullOrWhiteSpace(txtServicio.Text) &&
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

        private void btnMM1_Click(object sender, EventArgs e)
        {
            frmResultados frmResultados = new frmResultados();
            frmResultados.ShowDialog();
        }

        private void btnGraficas_Click(object sender, EventArgs e)
        {
            getGraphs();
        }

        public void getGraphs()
        {
            frmGraficas frmGraficas = new frmGraficas();

            // Configurar gráfico de barras
            frmGraficas.chartBarras.ChartAreas.Clear();
            frmGraficas.chartBarras.Series.Clear();
            frmGraficas.chartBarras.ChartAreas.Add("ChartArea");
            frmGraficas.chartBarras.Series.Add("Clientes Por Hora");
            frmGraficas.chartBarras.Series["Clientes Por Hora"].ChartType = SeriesChartType.Bar;

            // Establecer intervalo de 1 en ambos ejes
            frmGraficas.chartBarras.ChartAreas[0].AxisX.Interval = 1;
            frmGraficas.chartBarras.ChartAreas[0].AxisY.Interval = 1;


            // Obtener los datos de las columnas "Hora" y "Cantidad de Clientes" del DataGridView
            foreach (DataGridViewRow row in dataGeneral.Rows)
            {
                // Obtener los valores de las columnas
                int hora = Convert.ToInt32(row.Cells["Hora"].Value);
                int cantidadClientes = Convert.ToInt32(row.Cells["Cantidad de Clientes"].Value);

                // Crear un color aleatorio para cada barra
                Random random = new Random();
                Color color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

                // Agregar los datos al gráfico de barras
                frmGraficas.chartBarras.Series["Clientes Por Hora"].Points.AddXY(hora, cantidadClientes);
                frmGraficas.chartBarras.Series["Clientes Por Hora"].Points.Last().Color = color;
            }

            // Configurar gráfico de líneas
            frmGraficas.chartLineas.ChartAreas.Clear();
            frmGraficas.chartLineas.Series.Clear();
            frmGraficas.chartLineas.ChartAreas.Add("ChartArea");
            frmGraficas.chartLineas.Series.Add("Ganancia Por Hora");
            frmGraficas.chartLineas.Series["Ganancia Por Hora"].ChartType = SeriesChartType.Line;

            // Establecer intervalo de 1 en ambos ejes
            //frmGraficas.chartLineas.ChartAreas[0].AxisX.Interval = 1;

            // Obtener los datos de las columnas "Hora" y "Ganancia" del DataGridView
            foreach (DataGridViewRow row in dataGeneral.Rows)
            {
                // Obtener los valores de las columnas
                int hora = Convert.ToInt32(row.Cells["Hora"].Value);
                float ganancia = Convert.ToSingle(row.Cells["Ganancia"].Value);

                // Agregar los datos al gráfico de líneas
                frmGraficas.chartLineas.Series["Ganancia Por Hora"].Points.AddXY(hora, ganancia);
            }

            // Mostrar el formulario con los gráficos
            frmGraficas.ShowDialog();
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void getGastoHora()
        {
            float gastoTotal = operaciones.getGastoTotal();
            float gastoHora = gastoTotal / 30 / 8;

            labelGasto.Text = "Gasto por Hora: Q" + gastoHora.ToString("0.00");
        }

        private void labelGasto_Click(object sender, EventArgs e)
        {

        }

        public void showScenary()
        {
            labelEscenario.Visible = true;
            labelGasto.Visible = true;
            dataGeneral.Visible = true;

        }

        private void Simulador_Load(object sender, EventArgs e)
        {
            isSimulado();
        }
    }
}
