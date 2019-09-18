using System;
using System.Collections.Generic;

namespace ECHO_API.Domain.Models
{
    public partial class TipoIdentificacion
    {
        public TipoIdentificacion()
        {
            Pacientes = new HashSet<Pacientes>();
        }

        public byte IdTipoIdentificacion { get; set; }
        public string TipoIdentificacion1 { get; set; }
        public string Mascara { get; set; }
        public string Tipo { get; set; }
        public int Longitud { get; set; }

        public virtual ICollection<Pacientes> Pacientes { get; set; }
    }
}
