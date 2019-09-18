using System;
using System.Collections.Generic;

namespace ECHO_API.Domain.Models
{
    public partial class TiposExamenes
    {
        public TiposExamenes()
        {
            SolicitudExamenes = new HashSet<SolicitudExamenes>();
        }

        public int IdExamenes { get; set; }
        public int IdCategoria { get; set; }
        public string NombreExamen { get; set; }

        public virtual CategoriaExamenes IdCategoriaNavigation { get; set; }
        public virtual ICollection<SolicitudExamenes> SolicitudExamenes { get; set; }
    }
}
