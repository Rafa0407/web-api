using System;
using System.Collections.Generic;

namespace ECHO_API.Domain.Models
{
    public partial class AcompannantePaciente
    {
        public int IdAcompannante { get; set; }
        public string Identificacion { get; set; }
        public string NombreAcompañante { get; set; }
        public string Telefono { get; set; }
        public int? IdAdmision { get; set; }

        public virtual Admision IdAdmisionNavigation { get; set; }
    }
}
