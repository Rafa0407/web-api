using System;
using System.Collections.Generic;

namespace ECHO_API.Domain.Models
{
    public partial class NotasEvolucion
    {
        public int IdNotaEvolucion { get; set; }
        public DateTime? FechaNota { get; set; }
        public string Nota { get; set; }
        public string Indicaciones { get; set; }
        public bool? EstadoNota { get; set; }
        public int? PlanEvolucion { get; set; }

        public virtual PlanesEvolucion PlanEvolucionNavigation { get; set; }
    }
}
