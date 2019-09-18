using System;
using System.Collections.Generic;

namespace ECHO_API.Domain.Models
{
    public partial class Especialidades
    {
        public Especialidades()
        {
            AgendaConvenioDetalle = new HashSet<AgendaConvenioDetalle>();
            MedicoEspecialidad = new HashSet<MedicoEspecialidad>();
        }

        public int IdEspecialidad { get; set; }
        public string NombreEspecialidad { get; set; }
        public string Observaciones { get; set; }
        public bool? ActivoRm { get; set; }

        public virtual ICollection<AgendaConvenioDetalle> AgendaConvenioDetalle { get; set; }
        public virtual ICollection<MedicoEspecialidad> MedicoEspecialidad { get; set; }
    }
}
