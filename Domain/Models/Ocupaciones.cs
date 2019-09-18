using System;
using System.Collections.Generic;

namespace ECHO_API.Domain.Models
{
    public partial class Ocupaciones
    {
        public Ocupaciones()
        {
            Pacientes = new HashSet<Pacientes>();
        }

        public short IdOcupacion { get; set; }
        public string Ocupacion { get; set; }

        public virtual ICollection<Pacientes> Pacientes { get; set; }
    }
}
