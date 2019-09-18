using System;
using System.Collections.Generic;

namespace ECHO_API.Domain.Models
{
    public partial class AccesosAgenda
    {
        public int IdAcceso { get; set; }
        public short IdMedico { get; set; }
        public int IdUsuario { get; set; }

        public virtual Medicos IdMedicoNavigation { get; set; }
    }
}
