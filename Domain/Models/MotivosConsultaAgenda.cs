using System;
using System.Collections.Generic;

namespace ECHO_API.Domain.Models
{
    public partial class MotivosConsultaAgenda
    {
        public int IdMotivoConsulta { get; set; }
        public int IdAgenda { get; set; }
        public DateTime FechaAgregado { get; set; }
        public int IdmMca { get; set; }

        public virtual AgendaMedicos IdAgendaNavigation { get; set; }
        public virtual MotivosConsulta IdMotivoConsultaNavigation { get; set; }
    }
}
