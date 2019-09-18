using System;
using System.Collections.Generic;

namespace ECHO_API.Domain.Models
{
    public partial class SolicitudExamenes
    {
        public int IdSolicitudesExamen { get; set; }
        public int IdConsulta { get; set; }
        public int IdCategoria { get; set; }
        public int IdExamen { get; set; }
        public DateTime Fecha { get; set; }

        public virtual ConsultaMedica IdConsultaNavigation { get; set; }
        public virtual TiposExamenes IdExamenNavigation { get; set; }
    }
}
