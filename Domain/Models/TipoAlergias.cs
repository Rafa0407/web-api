using System;
using System.Collections.Generic;

namespace ECHO_API.Domain.Models
{
    public partial class TipoAlergias
    {
        public int IdTipoAlergia { get; set; }
        public string NombreAlergia { get; set; }
        public int? Alergias { get; set; }

        public virtual Alergias AlergiasNavigation { get; set; }
    }
}
