using System;
using System.Collections.Generic;

namespace ECHO_API.Domain.Models
{
    public partial class PersonalInternamiento
    {
        public PersonalInternamiento()
        {
            Internamientos = new HashSet<Internamientos>();
        }

        public int IdPersonalMedico { get; set; }

        public virtual ICollection<Internamientos> Internamientos { get; set; }
    }
}
