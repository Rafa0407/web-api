using System;
using System.Collections.Generic;

namespace ECHO_API.Domain.Models
{
    public partial class Medicos
    {
        public Medicos()
        {
            AccesosAgenda = new HashSet<AccesosAgenda>();
            AgendaMedicos = new HashSet<AgendaMedicos>();
            Internamientos = new HashSet<Internamientos>();
            MedicoEspecialidad = new HashSet<MedicoEspecialidad>();
            PerfilDetalleAccesoAgenda = new HashSet<PerfilDetalleAccesoAgenda>();
        }

        public short IdMedico { get; set; }
        public string CodMedico { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Grado { get; set; }
        public double PorcentajeMedico { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public short Categoria { get; set; }
        public short TiempoEntreConsultas { get; set; }
        public int Entidad { get; set; }
        public string HoraInicio { get; set; }
        public string HoraFinal { get; set; }
        public string CarpetaReportes { get; set; }
        public string Email { get; set; }
        public string Ubicacion { get; set; }
        public double ComisionTarjeta { get; set; }
        public string CuentaBancaria { get; set; }
        public string Banco { get; set; }
        public bool? Activo { get; set; }
        public bool? ActivoParaConvenios { get; set; }
        public bool? ActivoEmergencias { get; set; }
        public short FormatoImpresora { get; set; }
        public string Usuario { get; set; }
        public DateTime? Fecha { get; set; }
        public bool? ActivoRedMedica { get; set; }
        public bool? ActivoSiempre { get; set; }
        public bool? ActivoFacturador { get; set; }
        public string NombreCompleto { get; set; }

        public virtual EntidadJuridica EntidadNavigation { get; set; }
        public virtual ICollection<AccesosAgenda> AccesosAgenda { get; set; }
        public virtual ICollection<AgendaMedicos> AgendaMedicos { get; set; }
        public virtual ICollection<Internamientos> Internamientos { get; set; }
        public virtual ICollection<MedicoEspecialidad> MedicoEspecialidad { get; set; }
        public virtual ICollection<PerfilDetalleAccesoAgenda> PerfilDetalleAccesoAgenda { get; set; }
    }
}
