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
        getEscenarioTableAdapter getScenery = new getEscenarioTableAdapter();
        getHoraTableAdapter getHour = new getHoraTableAdapter();
        getProductCustomerTableAdapter getProductCustomer = new getProductCustomerTableAdapter();
        QueriesTableAdapter getQueries = new QueriesTableAdapter();

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

        public DataTable getEscenario(int escenario, int servicio)
        {
            DataTable dataTable = getScenery.GetData(escenario, servicio); 
            return dataTable;
        }

        public DataTable getHora(int escenario, int hora, int clientes)
        {
            DataTable dataTable = getHour.GetData(escenario, hora, clientes); 

            return dataTable;
        }

        public DataTable getProductoCliente(int escenario, int hora, int idCliente)
        {
            DataTable dataTable = getProductCustomer.GetData(escenario, hora, idCliente);
            return dataTable;
        }

        public void crearEscenarios(int horas, int clientes, int productos)
        {
            getQueries.InsertarEscenarios(horas, clientes, productos);
        }

        public void eliminarEscenarios()
        {
            getQueries.pEliminarEscenarios();
        }

        public DialogResult MostrarMensajeError(string mensaje)
        {
            return MessageBox.Show(mensaje, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }
    }
}
