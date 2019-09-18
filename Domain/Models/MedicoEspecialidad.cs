using System;
using System.Collections.Generic;

namespace ECHO_API.Domain.Models
{
    public partial class MedicoEspecialidad
    {
        public short IdMedicoEspecialidad { get; set; }
        public short IdMedico { get; set; }
        public int IdEspecialidad { get; set; }

        public virtual Especialidades IdEspecialidadNavigation { get; set; }
        public virtual Medicos IdMedicoNavigation { get; set; }
    }
}
