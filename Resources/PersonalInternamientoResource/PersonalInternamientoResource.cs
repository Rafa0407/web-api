using ECHO_API.Domain.Models;
using ECHO_API.Resources.FuncionPersonalIntr;
using ECHO_API.Resources.MedicosResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Resources.PersonalInternamientoResource
{
    public class PersonalIntrResource
    {
        public virtual FunPersInterResource IdFuncionNavigation { get; set; }
        public virtual MedicoResource IdMedicoNavigation { get; set; }

    }
}
