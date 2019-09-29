using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Resources.HistoriaClinicaResources.TiposAlergiasResources
{
    public class SaveTipoAlergiasResource
    {
        [Required]
        [MaxLength(50)]
        public string NombreAlergia { get; set; }
        [Required]
        public int? Alergias { get; set; }
    }
}
