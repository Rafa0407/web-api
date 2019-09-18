using System;
using System.Collections.Generic;

namespace ECHO_API.Domain.Models
{
    public partial class CategoriaExamenes
    {
        public CategoriaExamenes()
        {
            TiposExamenes = new HashSet<TiposExamenes>();
        }

        public int IdCategoria { get; set; }
        public string Categoria { get; set; }

        public virtual ICollection<TiposExamenes> TiposExamenes { get; set; }
    }
}
