using System;
using System.Collections.Generic;

namespace ECHO_API.Domain.Models
{
    public partial class FacturasDetalles
    {
        public int IdFacturasDetalles { get; set; }
        public int IdFactura { get; set; }
        public int Codigo { get; set; }
        public double Cantidad { get; set; }
        public string Descripcion { get; set; }
        public short PorcentageIv { get; set; }
        public double SubTotal { get; set; }
        public double ImpuestoVenta { get; set; }
        public double Descuento { get; set; }
        public double Total { get; set; }
        public double DescuentoPorc { get; set; }
        public double PorcentajeMedico { get; set; }
        public DateTime FechaRegistro { get; set; }
        public short IdMedico { get; set; }
        public short IdTipoJornada { get; set; }
        public string Origen { get; set; }
        public string Obs { get; set; }
        public string Usuario { get; set; }
        public string Bodega { get; set; }
        public string Lote { get; set; }
        public double PrecioUnitario { get; set; }
        public string CuentaContable { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string NombreInstitucion { get; set; }
        public DateTime? FechaEmision { get; set; }
        public double? PorcentajeExoneracion { get; set; }
        public double? MontoExoneracion { get; set; }
        public string TipoImpuesto { get; set; }
        public string TipoTarifa { get; set; }
        public string EsCanasta { get; set; }

        public virtual FacturasEncabezado IdFacturaNavigation { get; set; }
    }
}
