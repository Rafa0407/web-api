using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Resources.HistoriaClinicaResources.TiposAlergiasResources
{
    public class TipoAlergiasResource
    {
        public int IdTipoAlergia { get; set; }
        public string NombreAlergia { get; set; }
        public int? Alergias { get; set; }
    }
}
