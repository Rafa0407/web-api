using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Resources.AcompannanteResource
{
    public class SaveAcompannanteResource
    {
        [Required]
        [MaxLength(12)]
        public string Identificacion { get; set; }
        [Required]
        [MaxLength(255)]
        public string NombreAcompañante { get; set; }
        [Required]
        [MaxLength(10)]
        public string Telefono { get; set; }
        [Required]
        public int? IdAdmision { get; set; }
    }
}
