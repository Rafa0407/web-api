using System;
using System.Collections.Generic;

namespace ECHO_API.Domain.Models
{
    public partial class ControlSignos
    {
        public ControlSignos()
        {
            TomaSignos = new HashSet<TomaSignos>();
        }

        public int IdControlSignos { get; set; }
        public int? Internamiento { get; set; }

        public virtual Internamientos InternamientoNavigation { get; set; }
        public virtual ICollection<TomaSignos> TomaSignos { get; set; }
    }
}
