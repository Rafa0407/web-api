using System;
using System.Collections.Generic;

namespace ECHO_API.Domain.Models
{
    public partial class AgendaConvenioDetalle
    {
        public long IdagendaConvenioDetalle { get; set; }
        public long IdagendaConvenio { get; set; }
        public int IdEspecialidad { get; set; }
        public short IdMedico { get; set; }
        public DateTime FechaHora { get; set; }

        public virtual Especialidades IdEspecialidadNavigation { get; set; }
        public virtual AgendaConvenios IdagendaConvenioNavigation { get; set; }
    }
}
