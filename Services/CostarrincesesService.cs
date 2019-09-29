using ECHO_API.Domain.Models;
using ECHO_API.Domain.Repositories.CostarricensesBusquedaRepo;
using ECHO_API.Domain.Services.CostarricensesBusquedaService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Services
{
    public class CostarrincesesService : ICostarricensesService
    {
        private readonly ICostarricensesBusqueda _costarricensesBusqueda;
        public CostarrincesesService(ICostarricensesBusqueda costarricensesBusqueda)
        {
            _costarricensesBusqueda = costarricensesBusqueda; 
        }
        public async Task<CostarricensesBusqueda> FindByIdAsync(int id)
        {
            return await _costarricensesBusqueda.FindByIdAsync(id);
        }
    }
}
