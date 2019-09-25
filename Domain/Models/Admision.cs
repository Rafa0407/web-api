using System;
using System.Collections.Generic;

namespace ECHO_API.Domain.Models
{
    public partial class Admision
    {
        public Admision()
        {
            AcompannantePaciente = new HashSet<AcompannantePaciente>();
        }

        public int IdAdmision { get; set; }
        public int? CreadoPor { get; set; }
        public int? Internamiento { get; set; }
        public DateTime? FechaAdmision { get; set; }
        public short? HabitacionAsignada { get; set; }
        public string DiagnosticoIngreso { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public string DiagnosticoEgreso { get; set; }
        public string ProcedimientosRealizados { get; set; }
        public DateTime? FechaEgreso { get; set; }

        public virtual Usuarios CreadoPorNavigation { get; set; }
        public virtual Internamientos InternamientoNavigation { get; set; }
        public virtual ICollection<AcompannantePaciente> AcompannantePaciente { get; set; }
    }
}
