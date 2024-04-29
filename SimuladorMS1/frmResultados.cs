using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorMS1
{
    public partial class frmResultados : Form
    {
        Formulas formulas = new Formulas();

        public frmResultados()
        {
            InitializeComponent();
        }

        private void frmResultados_Load(object sender, EventArgs e)
        {
            getResults();
        }

        public void getResults()
        {
            double wq = formulas.getWq();
            double lq = formulas.getLq();
            double ws = formulas.getWs();
            double ls = formulas.getLs();
            double p = formulas.getP();
            double pn = formulas.getPn(0);

            labelWq.Text = "Tiempo de espera en la cola (Wq): " + wq.ToString();
            labelLq.Text = "Número de personas en la cola (Lq): " + lq.ToString();
            labelWs.Text = "Tiempo de espera en el sistema (Ws): " + ws.ToString();
            labelLs.Text = "Número de personas en el sistema (Ls): " + ls.ToString();
            labelP.Text = "Probabilidad de uso del sistema (P): " + p.ToString();
            labelP0.Text = "Probabilidad de ocio del sistema P(0): " + pn.ToString();
        }
    }
}
