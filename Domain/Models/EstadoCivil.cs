using System;
using System.Collections.Generic;

namespace ECHO_API.Domain.Models
{
    public partial class EstadoCivil
    {
        public EstadoCivil()
        {
            Pacientes = new HashSet<Pacientes>();
        }

        public byte IdEstadoCivil { get; set; }
        public string EstadoCivil1 { get; set; }

        public virtual ICollection<Pacientes> Pacientes { get; set; }
    }
}
