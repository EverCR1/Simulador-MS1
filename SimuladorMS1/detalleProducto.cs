using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorMS1
{
    internal class detalleProducto
    {
        public int No { get; set; }
        public string NombreProducto { get; set; }
        public decimal PrecioCosto { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal Utilidad { get; set; }
    }
}
