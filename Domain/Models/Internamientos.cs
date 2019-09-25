using System;
using System.Collections.Generic;

namespace ECHO_API.Domain.Models
{
    public partial class Internamientos
    {
        public Internamientos()
        {
            Admision = new HashSet<Admision>();
            ControlSignos = new HashSet<ControlSignos>();
            CosentimientoInformado = new HashSet<CosentimientoInformado>();
            HistoriaClinica = new HashSet<HistoriaClinica>();
            NotaOperatoria = new HashSet<NotaOperatoria>();
            NotasEnfermeria = new HashSet<NotasEnfermeria>();
            PersonalInternamiento = new HashSet<PersonalInternamiento>();
            PlanesEvolucion = new HashSet<PlanesEvolucion>();
        }

        public int IdInternamiento { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool? EstadoInternamiento { get; set; }
        public int? CreadoPor { get; set; }
        public int? PacienteInternamiento { get; set; }

        public virtual Usuarios CreadoPorNavigation { get; set; }
        public virtual Pacientes PacienteInternamientoNavigation { get; set; }
        public virtual ICollection<Admision> Admision { get; set; }
        public virtual ICollection<ControlSignos> ControlSignos { get; set; }
        public virtual ICollection<CosentimientoInformado> CosentimientoInformado { get; set; }
        public virtual ICollection<HistoriaClinica> HistoriaClinica { get; set; }
        public virtual ICollection<NotaOperatoria> NotaOperatoria { get; set; }
        public virtual ICollection<NotasEnfermeria> NotasEnfermeria { get; set; }
        public virtual ICollection<PersonalInternamiento> PersonalInternamiento { get; set; }
        public virtual ICollection<PlanesEvolucion> PlanesEvolucion { get; set; }
    }
}
