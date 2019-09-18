using System;
using System.Collections.Generic;

namespace ECHO_API.Domain.Models
{
    public partial class Pacientes
    {
        public Pacientes()
        {
            AgendaMedicos = new HashSet<AgendaMedicos>();
            AlergiasPaciente = new HashSet<AlergiasPaciente>();
            CasoConsulta = new HashSet<CasoConsulta>();
            DatosPadresNavigation = new HashSet<DatosPadres>();
            Internamientos = new HashSet<Internamientos>();
        }

        public int IdPaciente { get; set; }
        public string Identificacion { get; set; }
        public byte? IdTipoIdentificacion { get; set; }
        public short? IdNacionalidad { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Nombre { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string Genero { get; set; }
        public byte? IdEstadoCivil { get; set; }
        public short? IdOcupacion { get; set; }
        public byte? IdProvincia { get; set; }
        public short? IdCanton { get; set; }
        public int? IdDistrito { get; set; }
        public string OtrasSeñas { get; set; }
        public string TelefonoHabitacion { get; set; }
        public string TelefonoMovil { get; set; }
        public string TelefonoTrabajo { get; set; }
        public string GrupoSanguineo { get; set; }
        public string Rh { get; set; }
        public bool? TieneConyuge { get; set; }
        public string Csenc { get; set; }
        public string Apellido1Conyuge { get; set; }
        public string Apellido2Conyuge { get; set; }
        public string NombreConyuge { get; set; }
        public short? OcupacionConyuge { get; set; }
        public string TelefonoMovilConyuge { get; set; }
        public string TelefonoOficinaConyuge { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Usuario { get; set; }
        public string Email { get; set; }
        public string Email2 { get; set; }
        public int IdconverioEmpresas { get; set; }
        public bool PrimeraVez { get; set; }
        public string Nit { get; set; }
        public string NitApellido1 { get; set; }
        public string NitApellido2 { get; set; }
        public string NitNombre { get; set; }
        public string EdadActual { get; set; }
        public bool? Activo { get; set; }
        public DateTime? FechaActualiza { get; set; }
        public string NombreCompleto { get; set; }
        public string NitNombrecompleto { get; set; }
        public bool? Revisado { get; set; }
        public string Direccion { get; set; }
        public string ClienteExactus { get; set; }
        public string NumSeguro { get; set; }
        public string LugarNacimiento { get; set; }
        public int? DatosPadres { get; set; }

        public virtual Cantones IdCantonNavigation { get; set; }
        public virtual EstadoCivil IdEstadoCivilNavigation { get; set; }
        public virtual Nacionalidades IdNacionalidadNavigation { get; set; }
        public virtual Ocupaciones IdOcupacionNavigation { get; set; }
        public virtual Provincias IdProvinciaNavigation { get; set; }
        public virtual TipoIdentificacion IdTipoIdentificacionNavigation { get; set; }
        public virtual HistorialMedico HistorialMedico { get; set; }
        public virtual ICollection<AgendaMedicos> AgendaMedicos { get; set; }
        public virtual ICollection<AlergiasPaciente> AlergiasPaciente { get; set; }
        public virtual ICollection<CasoConsulta> CasoConsulta { get; set; }
        public virtual ICollection<DatosPadres> DatosPadresNavigation { get; set; }
        public virtual ICollection<Internamientos> Internamientos { get; set; }
    }
}
