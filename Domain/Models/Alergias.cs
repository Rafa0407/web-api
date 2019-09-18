using System;
using System.Collections.Generic;

namespace ECHO_API.Domain.Models
{
    public partial class Alergias
    {
        public Alergias()
        {
            TipoAlergias = new HashSet<TipoAlergias>();
        }

        public int IdAlergia { get; set; }
        public string Medicamento { get; set; }
        public int? HistoriaClinica { get; set; }

        public virtual HistoriaClinica HistoriaClinicaNavigation { get; set; }
        public virtual ICollection<TipoAlergias> TipoAlergias { get; set; }
    }
}
