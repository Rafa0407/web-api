using System;
using System.Collections.Generic;

namespace ECHO_API.Domain.Models
{
    public partial class NotasEnfermeria
    {
        public NotasEnfermeria()
        {
            ControlNotas = new HashSet<ControlNotas>();
        }

        public int IdNotaEnfermeria { get; set; }
        public int? Internamiento { get; set; }

        public virtual Internamientos InternamientoNavigation { get; set; }
        public virtual ICollection<ControlNotas> ControlNotas { get; set; }
    }
}
