using System;
using System.Collections.Generic;

namespace ECHO_API.Domain.Models
{
    public partial class Provincias
    {
        public Provincias()
        {
            Pacientes = new HashSet<Pacientes>();
        }

        public byte IdProvincia { get; set; }
        public string NombreProvincia { get; set; }

        public virtual ICollection<Pacientes> Pacientes { get; set; }
    }
}
