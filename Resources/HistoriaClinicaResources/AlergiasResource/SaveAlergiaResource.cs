using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Resources.HistoriaClinicaResources.AlergiasResource
{
    public class SaveAlergiaResource
    {
        [Required]
        public int? HistoriaClinica { get; set; }
    }
}
