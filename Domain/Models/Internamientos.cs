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
            PlanesEvolucion = new HashSet<PlanesEvolucion>();
        }

        public int IdInternamiento { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool? EstadoInternamiento { get; set; }
        public int? CreadoPor { get; set; }
        public short? MedicoEncargado { get; set; }
        public int? PacienteInternamiento { get; set; }
        public int? PersonalMedico { get; set; }

        public  Usuarios CreadoPorNavigation { get; set; }
        public  Medicos MedicoEncargadoNavigation { get; set; }
        public  Pacientes PacienteInternamientoNavigation { get; set; }
        public  PersonalInternamiento PersonalMedicoNavigation { get; set; }
        public  ICollection<Admision> Admision { get; set; }
        public  ICollection<ControlSignos> ControlSignos { get; set; }
        public  ICollection<CosentimientoInformado> CosentimientoInformado { get; set; }
        public  ICollection<HistoriaClinica> HistoriaClinica { get; set; }
        public  ICollection<NotaOperatoria> NotaOperatoria { get; set; }
        public  ICollection<NotasEnfermeria> NotasEnfermeria { get; set; }
        public  ICollection<PlanesEvolucion> PlanesEvolucion { get; set; }
    }
}
