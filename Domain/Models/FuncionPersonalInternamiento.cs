using System;
using System.Collections.Generic;

namespace ECHO_API.Domain.Models
{
    public partial class FuncionPersonalInternamiento
    {
        public FuncionPersonalInternamiento()
        {
            PersonalInternamiento = new HashSet<PersonalInternamiento>();
        }

        public int IdFuncionMedico { get; set; }
        public string DescripcionFuncion { get; set; }

        public virtual ICollection<PersonalInternamiento> PersonalInternamiento { get; set; }
    }
}
