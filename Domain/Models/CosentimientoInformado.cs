using System;
using System.Collections.Generic;

namespace ECHO_API.Domain.Models
{
    public partial class CosentimientoInformado
    {
        public int IdConsentimiento { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string ArchivoConsentimiento { get; set; }
        public int? Internamiento { get; set; }
        public int? CreadoPor { get; set; }

        public virtual Usuarios CreadoPorNavigation { get; set; }
        public virtual Internamientos InternamientoNavigation { get; set; }
    }
}
