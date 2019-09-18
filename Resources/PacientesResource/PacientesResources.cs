using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Resources.PacientesResource
{
    public class PacientesResources
    {
        public string Identificacion { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Nombre { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string Genero { get; set; }
        public short? IdNacionalidad { get; set; }
        public byte? IdEstadoCivil { get; set; }
        public string Email { get; set; }
        public string EdadActual { get; set; }
        public string NombreCompleto { get; set; }
        public string Direccion { get; set; }
        public string NumSeguro { get; set; }
        public string LugarNacimiento { get; set; }
        public string TelefonoHabitacion { get; set; }
        public string TelefonoMovil { get; set; }

        public ICollection<DatosPadresResource> DatosPadresNavigation { get; set; }
    }
}
