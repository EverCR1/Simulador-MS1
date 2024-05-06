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
    public partial class Gastos : Form
    {
        Operaciones operaciones = new Operaciones();
        public Gastos()
        {
            InitializeComponent();
        }

        private void Gastos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdSimuladorDataSet.tb_gasto' Puede moverla o quitarla según sea necesario.
            this.tb_gastoTableAdapter.Fill(this.bdSimuladorDataSet.tb_gasto);
            getGasto();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarGasto frm = new AgregarGasto();
            frm.ShowDialog();

            ActualizarTablaGastos();
        }

        public void getGasto()
        {
            float gastoTotal = operaciones.getGastoTotal();
            float gastoHora = gastoTotal / 30 / 8;

            labelGasto.Text = "Gasto por Hora: Q" + gastoHora.ToString("0.00");
        }

        public void ActualizarTablaGastos()
        {
            this.tb_gastoTableAdapter.Fill(this.bdSimuladorDataSet.tb_gasto);
            getGasto();
        }
    }
}
