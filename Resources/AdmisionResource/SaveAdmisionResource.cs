using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Resources.AdmisionResource
{
    public class SaveAdmisionResource
    {
        // Datos preliminares para crear la admision por parte del SAC
        [Required]
        public int? CreadoPor { get; set; } // SAC
        [Required]
        public int? Internamiento { get; set; } // SAC
        [Required]
        [DataType(DataType.Date)]
        public DateTime? FechaAdmision { get; set; }// SAC
        [Required]
        public short? HabitacionAsignada { get; set; } // SAC
    }
}
