using System;
using System.Collections.Generic;

namespace ECHO_API.Domain.Models
{
    public partial class Usuarios
    {
        public Usuarios()
        {
            Admision = new HashSet<Admision>();
            ControlNotas = new HashSet<ControlNotas>();
            CosentimientoInformado = new HashSet<CosentimientoInformado>();
            HistoriaClinica = new HashSet<HistoriaClinica>();
            Internamientos = new HashSet<Internamientos>();
            NotaOperatoria = new HashSet<NotaOperatoria>();
            PlanesEvolucion = new HashSet<PlanesEvolucion>();
            TomaSignos = new HashSet<TomaSignos>();
        }

        public int IdUsusario { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string ClaveEntrada { get; set; }
        public int Perfil { get; set; }
        public byte[] Foto { get; set; }
        public short? IdMedico { get; set; }
        public int DescuentoAutorizado { get; set; }
        public bool AnularFactura { get; set; }
        public bool Facturar { get; set; }
        public bool Cajero { get; set; }
        public bool? BloquearPc { get; set; }
        public short IdCajaAsignada { get; set; }
        public string Email { get; set; }
        public DateTime? UltimoAcceso { get; set; }
        public string LugarAcceso { get; set; }
        public bool AnularRecibos { get; set; }
        public bool? ExpImpFac { get; set; }
        public bool EditarDescripcion { get; set; }
        public bool EditarCantidad { get; set; }
        public bool EditarPrecio { get; set; }
        public string CreadoPor { get; set; }
        public string ModificadoPor { get; set; }
        public string CodPromotor { get; set; }
        public string Tel01 { get; set; }
        public bool? AsociarAMedico { get; set; }

        public virtual ICollection<Admision> Admision { get; set; }
        public virtual ICollection<ControlNotas> ControlNotas { get; set; }
        public virtual ICollection<CosentimientoInformado> CosentimientoInformado { get; set; }
        public virtual ICollection<HistoriaClinica> HistoriaClinica { get; set; }
        public virtual ICollection<Internamientos> Internamientos { get; set; }
        public virtual ICollection<NotaOperatoria> NotaOperatoria { get; set; }
        public virtual ICollection<PlanesEvolucion> PlanesEvolucion { get; set; }
        public virtual ICollection<TomaSignos> TomaSignos { get; set; }
    }
}
