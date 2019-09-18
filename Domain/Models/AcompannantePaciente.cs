using System;
using System.Collections.Generic;

namespace ECHO_API.Domain.Models
{
    public partial class AcompannantePaciente
    {
        public AcompannantePaciente()
        {
            Admision = new HashSet<Admision>();
        }

        public int IdAcompannante { get; set; }
        public string NombreAcompañante { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Telefono { get; set; }

        public virtual ICollection<Admision> Admision { get; set; }
    }
}
