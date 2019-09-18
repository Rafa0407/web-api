using System;
using System.Collections.Generic;

namespace ECHO_API.Domain.Models
{
    public partial class Distritos
    {
        public int IdDistrito { get; set; }
        public string NombreDistrito { get; set; }
        public int IdCanton { get; set; }
        public string CodigoDg2 { get; set; }
        public string CodigoDg1 { get; set; }
        public string Cdg3 { get; set; }
        public string Cdg4 { get; set; }
    }
}
