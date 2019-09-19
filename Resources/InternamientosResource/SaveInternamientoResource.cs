using ECHO_API.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Resources.InternamientosResource
{
    public class SaveInternamientosResource
    {
        [Required]
        public int IdInternamiento { get; set; }

        [Required]
        public bool? EstadoInternamiento { get; set; }

    }
}
