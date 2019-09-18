using System;
using System.Collections.Generic;

namespace ECHO_API.Domain.Models
{
    public partial class CasoConsulta
    {
        public int IdCaso { get; set; }
        public string Descripcion { get; set; }
        public int IdPaciente { get; set; }
        public string HistorialGineSangrado { get; set; }
        public string HistorialGineTratamiento { get; set; }

        public virtual Pacientes IdPacienteNavigation { get; set; }
    }
}
