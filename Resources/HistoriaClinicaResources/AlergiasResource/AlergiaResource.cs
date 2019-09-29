using ECHO_API.Resources.HistoriaClinicaResources.TiposAlergiasResources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Resources.HistoriaClinicaResources.AlergiasResource
{
    public class AlergiaResource
    {
        public int IdAlergia { get; set; }
        public string Medicamento { get; set; }
        public int? HistoriaClinica { get; set; }
        public virtual ICollection<TipoAlergiasResource> TipoAlergias { get; set; }
    }
}
