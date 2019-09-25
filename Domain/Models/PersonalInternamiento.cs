using System;
using System.Collections.Generic;

namespace ECHO_API.Domain.Models
{
    public partial class PersonalInternamiento
    {
        public int IdPersonalMedico { get; set; }
        public short? IdMedico { get; set; }
        public int? IdFuncion { get; set; }
        public int? Internamiento { get; set; }

        public virtual FuncionPersonalInternamiento IdFuncionNavigation { get; set; }
        public virtual Medicos IdMedicoNavigation { get; set; }
        public virtual Internamientos InternamientoNavigation { get; set; }
    }
}
