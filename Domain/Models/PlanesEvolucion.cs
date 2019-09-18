using System;
using System.Collections.Generic;

namespace ECHO_API.Domain.Models
{
    public partial class PlanesEvolucion
    {
        public PlanesEvolucion()
        {
            NotasEvolucion = new HashSet<NotasEvolucion>();
        }

        public int IdPlanesEvolucion { get; set; }
        public int? CreadoPor { get; set; }
        public int? Internamiento { get; set; }

        public virtual Usuarios CreadoPorNavigation { get; set; }
        public virtual Internamientos InternamientoNavigation { get; set; }
        public virtual ICollection<NotasEvolucion> NotasEvolucion { get; set; }
    }
}
