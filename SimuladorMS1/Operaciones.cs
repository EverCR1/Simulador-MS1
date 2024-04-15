using SimuladorMS1.bdSimuladorDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorMS1
{
    internal class Operaciones
    {
        Random random = new Random();
        getProductByIdTableAdapter getProduct = new getProductByIdTableAdapter();

        // Función que genera un número aleatorio y lo retorna
        public int setNumber(int min, int max)
        {
            
            int numeroAleatorio = random.Next(min, max + 1);

            return numeroAleatorio;
        }
        public DataTable getProducto(int id)
        {
            //DataTable dataTable = new DataTable();
            DataTable dataTable = getProduct.GetData(id); //Se busca el producto con el id
            return dataTable;
        }

        public DialogResult MostrarMensajeError(string mensaje)
        {
            return MessageBox.Show(mensaje, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }
    }
}
