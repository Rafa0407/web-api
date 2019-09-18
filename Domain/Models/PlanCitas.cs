using System;
using System.Collections.Generic;

namespace ECHO_API.Domain.Models
{
    public partial class PlanCitas
    {
        public int IdPlan { get; set; }
        public int IdConsulta { get; set; }
        public DateTime Fecha { get; set; }
        public string Especialidad { get; set; }
        public string Medico { get; set; }

        public virtual ConsultaMedica IdConsultaNavigation { get; set; }
    }
}
