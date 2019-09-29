using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Resources.AdmisionResource
{
    public class AcompannanteResource
    {
        public int IdAcompannante { get; set; }
        public string Identificacion { get; set; }
        public string NombreAcompañante { get; set; }
        public string Telefono { get; set; }

        public int? IdAdmision { get; set; }
    }
}
