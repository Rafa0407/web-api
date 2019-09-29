using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Resources.HistoriaClinicaResources.ExamenesFisicoResource
{
    public class SaveExamenFisicoResource
    {
        [Required]
        [DataType(DataType.Date)]
        public DateTime? FechaAplicacion { get; set; }
        [Required]
        [MaxLength(10)]
        public string PresionArterial { get; set; }
        [Required]
        public int? FrecuenciaCardiaca { get; set; }
        [Required]
        public int? FrecuenciaRespiratoria { get; set; }
        [Required]
        public int? Temperatura { get; set; }
        [Required]
        public int? SaturacionOxigeno { get; set; }
        [Required]
        public int? Talla { get; set; }
        [Required]
        public int? Peso { get; set; }
        [Required]
        [MaxLength(50)]
        public string Aspecto { get; set; }
        [Required]
        public int? HistoriaClinica { get; set; }
    }
}
