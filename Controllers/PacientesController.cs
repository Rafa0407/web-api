using AutoMapper;
using ECHO_API.Domain.Models;
using ECHO_API.Domain.Services.PacientesService;
using ECHO_API.Resources.PacientesResource;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Controllers
{
    [Route("/api/[controller]")]
    public class PacientesController : Controller
    {
        private readonly IPacientesService _pacientesServices;
        private readonly IMapper _mapper;

        public PacientesController(IPacientesService pacientesService, IMapper mapper)
        {
            _pacientesServices = pacientesService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<PacientesResources>> GetAllAsync()
        {
            var pacientes = await _pacientesServices.ListAsync();

            // Map our enumeration of categories to an enumeration of resources using the Map method. 
            //This method receives an instance of the class or collection we want to map and, 
            //through generic type definitions, it defines to what type of class or collection must be mapped.
            var resources = _mapper.Map<IEnumerable<Pacientes>, IEnumerable<PacientesResources>>(pacientes);
            return resources;
        }

        [HttpGet("{identificacion}")]
        public async Task<PacientesResources> GetByIdAsync(string identificacion)
        {

            var paciente = await _pacientesServices.FindByIdAsync(identificacion);
            // Map our enumeration of categories to an enumeration of resources using the Map method. 
            //This method receives an instance of the class or collection we want to map and, 
            //through generic type definitions, it defines to what type of class or collection must be mapped.
            var resources = _mapper.Map<Pacientes, PacientesResources>(paciente.Pacientes);
            return resources;
        }


    }
}
