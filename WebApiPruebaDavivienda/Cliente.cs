using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiPruebaDavivienda
{
    [Serializable]
    public class Cliente
    {
        public int IdTercero { get; set; }
        public string Identificacion { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string PaginaWeb { get; set; }
        public string IdTipoIdentificacion { get; set; }

    }
}
