using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorMS1
{
    internal class Operaciones
    {

        // Función que genera un número aleatorio y lo retorna
        static int setNumber()
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(0, 63);

            return numeroAleatorio;
        }

        public DialogResult MostrarMensajeError(string mensaje)
        {
            return MessageBox.Show(mensaje, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }
    }
}
