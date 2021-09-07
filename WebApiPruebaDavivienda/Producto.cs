using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiPruebaDavivienda
{
    [Serializable]
    public class Producto
    {
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public int PresioActual { get; set; }
        public string Stock { get; set; }
        public int IdProveedor { get; set; }
    }
}
