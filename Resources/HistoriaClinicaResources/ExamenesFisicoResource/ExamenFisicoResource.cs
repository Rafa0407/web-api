using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Resources.HistoriaClinicaResources.ExamenesFisicoResource
{
    public class ExamenFisicoResource
    {
        public int IdExamenFisico { get; set; }
        public DateTime? FechaAplicacion { get; set; }
        public string PresionArterial { get; set; }
        public int? FrecuenciaCardiaca { get; set; }
        public int? FrecuenciaRespiratoria { get; set; }
        public int? Temperatura { get; set; }
        public int? SaturacionOxigeno { get; set; }
        public int? Talla { get; set; }
        public int? Peso { get; set; }
        public string Aspecto { get; set; }
        public int? HistoriaClinica { get; set; }
    }
}
