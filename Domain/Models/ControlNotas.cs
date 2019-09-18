using System;
using System.Collections.Generic;

namespace ECHO_API.Domain.Models
{
    public partial class ControlNotas
    {
        public int IdControlNotas { get; set; }
        public DateTime? FechaNota { get; set; }
        public string MedicamentoSuministrado { get; set; }
        public string Nota { get; set; }
        public int? CreadoPor { get; set; }
        public int? NotasEnfermeria { get; set; }

        public virtual Usuarios CreadoPorNavigation { get; set; }
        public virtual NotasEnfermeria NotasEnfermeriaNavigation { get; set; }
    }
}
