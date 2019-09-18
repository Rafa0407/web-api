using System;
using System.Collections.Generic;

namespace ECHO_API.Domain.Models
{
    public partial class EmpresaConvenios
    {
        public EmpresaConvenios()
        {
            AgendaConvenios = new HashSet<AgendaConvenios>();
        }

        public int IdConvenio { get; set; }
        public string EmpresaConvenio { get; set; }
        public double? PorcentajeDescuento { get; set; }
        public string Incluye { get; set; }
        public string TramiteDeFacturas { get; set; }
        public short PlazoDeCredito { get; set; }
        public bool? Activo { get; set; }
        public bool ActivoAgendaConvenio { get; set; }
        public string Telefono01 { get; set; }
        public string Telefono02 { get; set; }
        public string Identificacion { get; set; }
        public short? Tipo { get; set; }
        public string NombreCorto { get; set; }
        public long? NumeroConvenio { get; set; }
        public string Email { get; set; }
        public string Contacto { get; set; }
        public string CuentaContable { get; set; }
        public string DescripcionCc { get; set; }
        public string Observaciones { get; set; }
        public bool InterCompany { get; set; }
        public DateTime? VenceContrato { get; set; }
        public string NumeroContrato { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioActualiza { get; set; }
        public string UsuarioCreador { get; set; }
        public double? LimiteCreditoLocal { get; set; }
        public bool PermiteCanje { get; set; }
        public bool CreditoActivo { get; set; }
        public int IdEmpresa { get; set; }

        public virtual ICollection<AgendaConvenios> AgendaConvenios { get; set; }
    }
}
