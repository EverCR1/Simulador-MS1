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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdSimuladorDataSet1.tb_producto' Puede moverla o quitarla según sea necesario.
            this.tb_productoTableAdapter.Fill(this.bdSimuladorDataSet1.tb_producto);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void agregarp_Click(object sender, EventArgs e)
        {
            AgregarProducto frm = new AgregarProducto();
            frm.ShowDialog();
        }
    }
}
