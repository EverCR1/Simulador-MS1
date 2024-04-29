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
    public partial class frmClientes : Form
    {

        public frmClientes()
        {
            InitializeComponent();

            dataClientes.DefaultCellStyle.Font = new Font("Arial", 12);
            // Cambiar el color de fondo de la primera fila
            dataClientes.Rows[0].DefaultCellStyle.BackColor = Color.LightBlue;
        }
    }
}
