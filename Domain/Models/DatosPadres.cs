using System;
using System.Collections.Generic;

namespace ECHO_API.Domain.Models
{
    public partial class DatosPadres
    {
        public int IdDatosPadres { get; set; }
        public string IdentificacionPadre { get; set; }
        public string IdentificacionMadre { get; set; }
        public string NombrePadre { get; set; }
        public string NombreMadre { get; set; }
        public int? Paciente { get; set; }

        public virtual Pacientes PacienteNavigation { get; set; }
    }
}
