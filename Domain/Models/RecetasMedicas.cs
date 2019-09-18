using System;
using System.Collections.Generic;

namespace ECHO_API.Domain.Models
{
    public partial class RecetasMedicas
    {
        public int IdDetalleRecetas { get; set; }
        public int? IdConsulta { get; set; }
        public int? Cantidad { get; set; }
        public string Descripcion { get; set; }
        public string Presentacion { get; set; }
        public string Dosis { get; set; }

        public virtual ConsultaMedica IdConsultaNavigation { get; set; }
    }
}
