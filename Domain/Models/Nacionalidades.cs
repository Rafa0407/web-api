using System;
using System.Collections.Generic;

namespace ECHO_API.Domain.Models
{
    public partial class Nacionalidades
    {
        public Nacionalidades()
        {
            Pacientes = new HashSet<Pacientes>();
        }

        public short IdNacionalidad { get; set; }
        public string NombrePais { get; set; }
        public string CodigoInternacional { get; set; }

        public virtual ICollection<Pacientes> Pacientes { get; set; }
    }
}
