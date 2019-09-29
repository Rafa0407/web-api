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
        public int? Internamiento { get; set; } // automatico en el request

        [Required]
        [MaxLength(255)]
        public string DiagnosticoIngreso { get; set; } // MEDICO
        [Required]
        public DateTime? FechaIngreso { get; set; } // MEDICO

        // A partir de estos datos se permiten nulos, ya que el egreso se da hasta que el paciente parte del hospital, 
        // llenado esto el internamiento tambien debe queda inactivo
        [MaxLength(255)]
        public string DiagnosticoEgreso { get; set; } // MEDICO - EGRESO 
        [MaxLength(255)]
        public string ProcedimientosRealizados { get; set; } // MEDICO - EGRESO
        public DateTime? FechaEgreso { get; set; } // MEDICO - EGRESO
    }
}
