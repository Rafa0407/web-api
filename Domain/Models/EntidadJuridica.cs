using System;
using System.Collections.Generic;

namespace ECHO_API.Domain.Models
{
    public partial class EntidadJuridica
    {
        public EntidadJuridica()
        {
            Medicos = new HashSet<Medicos>();
        }

        public int IdEmpresa { get; set; }
        public string Empresa { get; set; }
        public string Cedula { get; set; }
        public string Telefonos { get; set; }
        public string Direccion { get; set; }
        public string Frase { get; set; }
        public string Fax { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string CodCompYam { get; set; }
        public bool Facturar { get; set; }
        public bool Activa { get; set; }

        public virtual ICollection<Medicos> Medicos { get; set; }
    }
}
