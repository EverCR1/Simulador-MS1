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
