using System;
using System.Collections.Generic;

namespace ECHO_API.Domain.Models
{
    public partial class TomaSignos
    {
        public int IdTomaSignos { get; set; }
        public DateTime? FechaToma { get; set; }
        public int? CreadoPor { get; set; }
        public string PresionArterial { get; set; }
        public string Temperatura { get; set; }
        public string SaturacionOxigeno { get; set; }
        public string FrecuenciaRespiratoria { get; set; }
        public string FrecienciaCardiaca { get; set; }
        public int? ControlSignos { get; set; }

        public virtual ControlSignos ControlSignosNavigation { get; set; }
        public virtual Usuarios CreadoPorNavigation { get; set; }
    }
}
