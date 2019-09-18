using System;
using System.Collections.Generic;

namespace ECHO_API.Domain.Models
{
    public partial class PerfilDetalleAccesoAgenda
    {
        public int IdPerfilDetalle { get; set; }
        public int IdPerfil { get; set; }
        public short IdMedico { get; set; }

        public virtual Medicos IdMedicoNavigation { get; set; }
    }
}
