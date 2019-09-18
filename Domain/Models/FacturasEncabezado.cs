using System;
using System.Collections.Generic;

namespace ECHO_API.Domain.Models
{
    public partial class FacturasEncabezado
    {
        public FacturasEncabezado()
        {
            FacturasDetalles = new HashSet<FacturasDetalles>();
        }

        public int IdFactura { get; set; }
        public int IdConsulta { get; set; }
        public long NumeroFactura { get; set; }
        public string ClientePagador { get; set; }
        public string TipoFactura { get; set; }
        public DateTime Fecha { get; set; }
        public double SubTotal { get; set; }
        public double ImpuestoVenta { get; set; }
        public double Descuento { get; set; }
        public double Total { get; set; }
        public bool Anulada { get; set; }
        public string Usuario { get; set; }
        public bool CanceladoCaja { get; set; }
        public int Entidad { get; set; }
        public string AutorizacionDescuento { get; set; }
        public double PorcentajeDescAutorizado { get; set; }
        public int IdConvenio { get; set; }
        public double TipoCambio { get; set; }
        public int Idmoneda { get; set; }
        public string CodigoTurno { get; set; }
        public string Observaciones { get; set; }
        public long Iht { get; set; }
        public short PuntoVenta { get; set; }
        public string Nic { get; set; }
        public short Plazo { get; set; }
        public short FormatoImpresora { get; set; }
        public double TotalCancelado { get; set; }
        public double Saldo { get; set; }
        public bool PreAnulado { get; set; }
        public string UsuarioAutoAnulado { get; set; }
        public DateTime? FechaPreAnulado { get; set; }
        public string Fp { get; set; }
        public string OrdenServicio { get; set; }
        public string IdentificacionCliente { get; set; }
        public string Apellido1Cliente { get; set; }
        public string Apellido2Cliente { get; set; }
        public string NombreCliente { get; set; }
        public string Status { get; set; }
        public int? SubTipoFactura { get; set; }
        public bool? Proformada { get; set; }
        public long? IdGestion { get; set; }
        public double Tcc { get; set; }
        public double Tcv { get; set; }
        public string Promotor { get; set; }
        public long? CertificadoNumero { get; set; }
        public double? SubTotalDolar { get; set; }
        public double? ImpuestoDolar { get; set; }
        public double? DescuentoDolar { get; set; }
        public double? TotalDolar { get; set; }
        public bool MigradoExactus { get; set; }
        public string ConsecutivoExactus { get; set; }
        public DateTime? FechaMigrado { get; set; }
        public string NotaCreditoExactus { get; set; }
        public DateTime? FechaNotaCreExactus { get; set; }
        public double TotalExonerado { get; set; }
        public double TotalIvadevuelto { get; set; }
        public bool AplicacadoIvaDevuelto { get; set; }

        public virtual ConsultaMedica IdConsultaNavigation { get; set; }
        public virtual ICollection<FacturasDetalles> FacturasDetalles { get; set; }
    }
}
