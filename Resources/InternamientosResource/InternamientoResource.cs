using ECHO_API.Domain.Models;
using ECHO_API.Resources.AdmisionResource;
using ECHO_API.Resources.MedicosResource;
using ECHO_API.Resources.PacientesResource;
using ECHO_API.Resources.PersonalInternamientoResource;
using ECHO_API.Resources.UsuariosResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Resources.InternamientosResource
{
    public class InternamientoResource
    {
        public int IdInternamiento { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool? EstadoInternamiento { get; set; }

        public virtual UsuarioResource CreadoPorNavigation { get; set; }
        public virtual PacientesResources PacienteInternamientoNavigation { get; set; }
        public virtual ICollection<AdmisnResource> Admision { get; set; }
        public virtual ICollection<ControlSignos> ControlSignos { get; set; }
        public virtual ICollection<CosentimientoInformado> CosentimientoInformado { get; set; }
        public virtual ICollection<HistoriaClinica> HistoriaClinica { get; set; }
        public virtual ICollection<NotaOperatoria> NotaOperatoria { get; set; }
        public virtual ICollection<NotasEnfermeria> NotasEnfermeria { get; set; }
        public virtual ICollection<PersonalIntrResource> PersonalInternamiento { get; set; }
        public virtual ICollection<PlanesEvolucion> PlanesEvolucion { get; set; }
    }
}
