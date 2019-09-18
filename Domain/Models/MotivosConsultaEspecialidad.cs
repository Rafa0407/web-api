using System;
using System.Collections.Generic;

namespace ECHO_API.Domain.Models
{
    public partial class MotivosConsultaEspecialidad
    {
        public int IdMotivoConsulta { get; set; }
        public int IdEspecialidad { get; set; }
        public int IdMce { get; set; }
    }
}
