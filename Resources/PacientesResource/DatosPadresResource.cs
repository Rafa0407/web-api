using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Resources.PacientesResource
{
    public class DatosPadresResource
    {
        public int IdDatosPadres { get; set; }
        public string IdentificacionPadre { get; set; }
        public string IdentificacionMadre { get; set; }
        public string NombrePadre { get; set; }
        public string NombreMadre { get; set; }
    }
}
