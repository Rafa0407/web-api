using System;
using System.Collections.Generic;

namespace ECHO_API.Domain.Models
{
    public partial class MotivosConsulta
    {
        public MotivosConsulta()
        {
            MotivosConsultaAgenda = new HashSet<MotivosConsultaAgenda>();
        }

        public int IdMotivoConsulta { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<MotivosConsultaAgenda> MotivosConsultaAgenda { get; set; }
    }
}
