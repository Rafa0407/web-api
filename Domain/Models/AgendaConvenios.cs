using System;
using System.Collections.Generic;

namespace ECHO_API.Domain.Models
{
    public partial class AgendaConvenios
    {
        public AgendaConvenios()
        {
            AgendaConvenioDetalle = new HashSet<AgendaConvenioDetalle>();
        }

        public long IdAgendaConvenio { get; set; }
        public DateTime Fecha { get; set; }
        public int IdPaciente { get; set; }
        public int Idconvenio { get; set; }
        public bool? Cancelada { get; set; }
        public bool? Atendido { get; set; }
        public string Usuario { get; set; }

        public virtual EmpresaConvenios IdconvenioNavigation { get; set; }
        public virtual ICollection<AgendaConvenioDetalle> AgendaConvenioDetalle { get; set; }
    }
}
