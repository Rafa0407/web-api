using System;
using System.Collections.Generic;

namespace ECHO_API.Domain.Models
{
    public partial class HistorialMedico
    {
        public int IdHistorialMedico { get; set; }
        public int IdPaciente { get; set; }
        public string HistorialPatogeno { get; set; }
        public string HistorialNoPatogeno { get; set; }
        public string HistorialClinico { get; set; }
        public string HistorialFamiliar { get; set; }

        public virtual Pacientes IdPacienteNavigation { get; set; }
    }
}
