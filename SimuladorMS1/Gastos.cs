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
        public Gastos()
        {
            InitializeComponent();
        }

        private void Gastos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdSimuladorDataSet.tb_gasto' Puede moverla o quitarla según sea necesario.
            this.tb_gastoTableAdapter.Fill(this.bdSimuladorDataSet.tb_gasto);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarGasto frm = new AgregarGasto();
            frm.ShowDialog();
        }
    }
}
