using System;
using System.Collections.Generic;

namespace ECHO_API.Domain.Models
{
    public partial class Cantones
    {
        public Cantones()
        {
            Pacientes = new HashSet<Pacientes>();
        }

        public short IdCanton { get; set; }
        public string NombreCanton { get; set; }
        public byte IdProvincia { get; set; }
        public string CodigoDg { get; set; }

        public virtual ICollection<Pacientes> Pacientes { get; set; }
    }
}
