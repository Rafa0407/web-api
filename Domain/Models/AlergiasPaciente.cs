using System;
using System.Collections.Generic;

namespace ECHO_API.Domain.Models
{
    public partial class AlergiasPaciente
    {
        public int IdPaciente { get; set; }
        public int IdAlergia { get; set; }

        public virtual Pacientes IdPacienteNavigation { get; set; }
    }
}
