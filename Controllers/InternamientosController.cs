using AutoMapper;
using ECHO_API.Domain.Models;
using ECHO_API.Domain.Services.InternamientosService;
using ECHO_API.Extensions;
using ECHO_API.Resources.InternamientosResource;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Controllers
{
    [Route("/api/[controller]")]
    public class InternamientosController : Controller
    {
        private readonly IInternamientosService _internamientosService;
        private readonly IMapper _mapper;

        public InternamientosController(IInternamientosService internamientosService, IMapper mapper)
        {
            _internamientosService = internamientosService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<InternamientoResource>> GetAllAsync()
        {
            var internamientos = await _internamientosService.ListAsync();

            var resource = _mapper.Map<IEnumerable<Internamientos>, IEnumerable<InternamientoResource>>(internamientos);

            return resource;
        }

        [HttpGet("{id}")]
        public async Task<InternamientoResource> GetByIdAsync(int id)
        {
            var internamiento = await _internamientosService.FindByIdAsync(id);

            var iresource = _mapper.Map<Internamientos, InternamientoResource>(internamiento);

            return iresource;
        }

        [HttpPut]
        public async Task<IActionResult> PutAsync([FromBody] SaveInternamientosResource internamiento)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            var uinternamiento = _mapper.Map<SaveInternamientosResource, Internamientos>(internamiento);
            var result = await _internamientosService.UpdateAsync(uinternamiento);

            if (!result.Success)
                return BadRequest(result.Message);

            var internamientoResource = _mapper.Map<Internamientos, InternamientoResource>(result.Internamientos);

            return Ok(internamientoResource);
        }

    }
}
