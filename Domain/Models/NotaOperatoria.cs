using System;
using System.Collections.Generic;

namespace ECHO_API.Domain.Models
{
    public partial class NotaOperatoria
    {
        public int IdNotaOperatoria { get; set; }
        public int? CreadoPor { get; set; }
        public int? Internamiento { get; set; }
        public DateTime? FechaNota { get; set; }
        public string DiagnosticoPreoperatorio { get; set; }
        public string DiagnosticoPostoperatorio { get; set; }
        public string CirugíaRealizada { get; set; }
        public string Hallazgos { get; set; }
        public string TecnicaEmpleada { get; set; }
        public string Observaciones { get; set; }

        public virtual Usuarios CreadoPorNavigation { get; set; }
        public virtual Internamientos InternamientoNavigation { get; set; }
    }
}
