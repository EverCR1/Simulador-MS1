using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace SimuladorMS1
{
    internal class Formulas
    {
        public int id { get; set; }
        public double Ls { get; set; }
        public double Lq { get; set; }
        public double Ws { get; set; }
        public double Wq { get; set; }
        public double λ { get; set; } // Lambda
        public double µ { get; set; } // Miu, obtener con Alt + 230 

        public double e = 2.7182818284; // Número de Euler

        public static int escenario { get; set; } // Constante del número de escenario donde nos encontramos
        public static int mediaClientes { get; set; }  // Constante de la cantidad para la Media de Clientes por Hora
        public static int mediaProductos { get; set; } // Constante de la cantidad de Productos que compra un Cliente
        public static int idHora { get; set; } // Constante de la Hora donde nos encontramos
        public static int idCliente { get; set; } // Constante para el id del cliente a visualizar
        public static int tiempoServicio { get; set; } // Constante del tiempo de servicio
        public static int horas { get; set; } // Constante de la cantidad de horas a Simular

        // MODELO MM1
        // Obtener Ls
        public double getLs()
        {
            double res = λ / (µ - λ);
            return res;
        }

        // Obtener Lq
        public double getLq()
        {
            double res = Math.Pow(λ, 2) / (µ * (µ - λ));
            return res;
        }

        // Obtener Ws
        public double getWs()
        {
            double res = 1 / (µ - λ);
            return res;
        }

        // Obtener Wq
        public double getWq()
        {
            double res = λ / (µ * (µ - λ));
            return res;
        }

        // Obtener P
        public double getP()
        {
            double res = λ / µ;
            return res;
        }

        // Obtener Pn
        public double getPn(double num)
        {
            double res = (1 - (λ / µ)) * Math.Pow((λ / µ), num);
            return res;
        }




    }
}
