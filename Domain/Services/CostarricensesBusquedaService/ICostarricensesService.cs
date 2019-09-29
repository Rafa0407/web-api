using ECHO_API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Domain.Services.CostarricensesBusquedaService
{
    public interface ICostarricensesService
    {
        Task<CostarricensesBusqueda> FindByIdAsync(int identificacion);
    }
}
