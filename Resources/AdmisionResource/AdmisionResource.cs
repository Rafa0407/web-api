using ECHO_API.Domain.Models;
using ECHO_API.Resources.InternamientosResource;
using ECHO_API.Resources.UsuariosResource;
using System;


namespace ECHO_API.Resources.AdmisionResource
{
    public class AdmisionResource
    {
        public int IdIadmision { get; set; }
        public DateTime? FechaAdmision { get; set; }
        public short? HabitacionAsignada { get; set; }
        public string DiagnosticoIngreso { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public string DiagnosticoEgreso { get; set; }
        public string ProcedimientosRealizados { get; set; }
        public AcompannantePaciente AcompannantesNavigation { get; set; }
        public UsuarioResource CreadoPorNavigation { get; set; }
        public InternamientoResource InternamientoNavigation { get; set; }

    }
}
