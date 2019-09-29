using ECHO_API.Domain.Models;
using ECHO_API.Resources.InternamientosResource;
using ECHO_API.Resources.UsuariosResource;
using System;
using System.Collections.Generic;

namespace ECHO_API.Resources.AdmisionResource
{
    public class AdmisnResource
    {
        public int IdIadmision { get; set; }
        public int? Internamiento { get; set; }
        public DateTime? FechaAdmision { get; set; }
        public short? HabitacionAsignada { get; set; }
        public string DiagnosticoIngreso { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public string DiagnosticoEgreso { get; set; }
        public string ProcedimientosRealizados { get; set; }
        public virtual ICollection<AcompannanteResource> AcompannantePaciente { get; set; }
        public UsuarioResource CreadoPorNavigation { get; set; }
        //public InternamientoResource InternamientoNavigation { get; set; }

    }
}
