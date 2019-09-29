using ECHO_API.Domain.Models;
using ECHO_API.Domain.Services.CostarricensesBusquedaService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Controllers
{
    [Route("/api/[controller]")]
    public class CostarricensesController : Controller
    {
        private readonly ICostarricensesService _costarricensesService; 

        public CostarricensesController(ICostarricensesService costarricensesService)
        {
            _costarricensesService = costarricensesService;
        }

        [HttpGet("{id}")]
        public async Task<CostarricensesBusqueda> GetGetByIdAsync(int id)
        {
            return await _costarricensesService.FindByIdAsync(id);
        }
    }
}
