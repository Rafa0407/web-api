using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Resources.AdmisionResource
{
    public class SaveAdmisionResource
    {
        [Required]
        public int? CreadoPor { get; set; } // SAC
        [Required]
        public int? Internamiento { get; set; } // SAC
        [Required]
        public DateTime? FechaAdmision { get; set; }// SAC
        [Required]
        public short? HabitacionAsignada { get; set; } // SAC
    }
}
