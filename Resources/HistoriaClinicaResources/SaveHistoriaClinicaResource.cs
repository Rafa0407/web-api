using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Resources.HistoriaClinicaResources
{
    public class SaveHistoriaClinicaResource
    {
        [Required]
        public int? Internamiento { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime? FechaHistoria { get; set; }
        [Required]
        public int? CreadoPor { get; set; }
        [Required]
        [MaxLength(50)]
        public string Servicio { get; set; }
        [Required]
        public int? Peso { get; set; }
        [Required]
        public short? Talla { get; set; }
        [Required]
        public bool? EstadoVacunacion { get; set; }
        [Required]
        [MaxLength(255)]
        public string Afh { get; set; }
        [Required]
        [MaxLength(255)]
        public string App { get; set; }
        [Required]
        [MaxLength(255)]
        public string Aqxt { get; set; }
        [Required]
        [MaxLength(255)]
        public string Ago { get; set; }
        [Required]
        [MaxLength(255)]
        public string TratamientoActual { get; set; }
        [MaxLength(255)]
        public string OtrosDatos { get; set; }
        [Required]
        [MaxLength(255)]
        public string EstadoNeurológico { get; set; }
        [Required]
        [MaxLength(255)]
        public string Oftalmológico { get; set; }
        [Required]
        [MaxLength(255)]
        public string Cuello { get; set; }
        [Required]
        [MaxLength(255)]
        public string Orl { get; set; }
        [Required]
        [MaxLength(255)]
        public string PaladarDentadura { get; set; }
        [Required]
        [MaxLength(255)]
        public string Cardiaco { get; set; }
        [Required]
        [MaxLength(255)]
        public string ToraxPulmonar { get; set; }
        [Required]
        [MaxLength(255)]
        public string Abdomen { get; set; }
        [Required]
        [MaxLength(255)]
        public string Extremidades { get; set; }
        [Required]
        [MaxLength(255)]
        public string Pulsos { get; set; }
        [Required]
        [MaxLength(255)]
        public string PielAnexos { get; set; }
        [MaxLength(255)]
        public string TactoVaginal { get; set; }
        [MaxLength(255)]
        public string TactoRectal { get; set; }

    }
}
