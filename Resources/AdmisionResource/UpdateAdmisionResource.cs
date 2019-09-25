using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Resources.AdmisionResource
{
    public class UpdateAdmisionResource
    {
        [Required]
        public int? Internamiento { get; set; } // automatico

        [Required]
        [MaxLength(255)]
        public string DiagnosticoIngreso { get; set; } // MEDICO
        [Required]
        public DateTime? FechaIngreso { get; set; } // MEDICO

        [MaxLength(255)]
        public string ProcedimientosRealizados { get; set; } // MEDICO - EGRESO
        public DateTime? FechaEgreso { get; set; } // MEDICO - EGRESO
    }
}
