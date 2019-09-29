using AutoMapper;
using ECHO_API.Domain.Models;
using ECHO_API.Domain.Services.AdmisionService.AcompannatesService;
using ECHO_API.Extensions;
using ECHO_API.Resources.AcompannanteResource;
using ECHO_API.Resources.AdmisionResource;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Controllers
{
    [Route("/api/[controller]")]
    public class AcompannantesController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IAcompannantesService _acompannantesService;

        public AcompannantesController(IMapper mapper, IAcompannantesService acompannantesService)
        {
            _mapper = mapper;
            _acompannantesService = acompannantesService;
        }

        [HttpGet]
        public async Task<IEnumerable<AcompannanteResource>> GetAllAsync()
        {
            var acompannantes = await _acompannantesService.ListAsync();
            var acompresource = _mapper.Map<IEnumerable<AcompannantePaciente>, IEnumerable<AcompannanteResource>>(acompannantes);
            return acompresource;
        }
        [HttpGet("{id}")]
        public async Task<AcompannanteResource> GetByIdAsync(int id)
        {
            var acompannante = await _acompannantesService.FindByIdAsync(id);
            var acompresource = _mapper.Map<AcompannantePaciente, AcompannanteResource>(acompannante);

            return acompresource;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SaveAcompannanteResource saveAcompannanteResource)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { message = ModelState.GetErrorMessages()});

            var acompannante = _mapper.Map<SaveAcompannanteResource, AcompannantePaciente>(saveAcompannanteResource);
            var acompresult = await _acompannantesService.SaveAsync(acompannante);

            if (!acompresult.Success)
                return BadRequest(new { message = acompresult.Message });

            var adminresource = _mapper.Map<AcompannantePaciente, AcompannanteResource>(acompresult.Acompannante);
            return Ok(adminresource);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(int id,[FromBody] SaveAcompannanteResource updateAcompannanteResource)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { message = ModelState.GetErrorMessages() });
            var acompannante = _mapper.Map<SaveAcompannanteResource, AcompannantePaciente>(updateAcompannanteResource);
            var acompresult = await _acompannantesService.UpdateAsync(id, acompannante);

            if (!acompresult.Success)
                return BadRequest(new { message = acompresult.Message });

            var adminresource = _mapper.Map<AcompannantePaciente, AcompannanteResource>(acompresult.Acompannante);
            return Ok(adminresource);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var acompannante = await _acompannantesService.RemoveAsync(id);

            if (!acompannante.Success)
                return BadRequest(new { message = acompannante.Message });

            var acompannteresult = _mapper.Map<AcompannantePaciente, AcompannanteResource>(acompannante.Acompannante);

            var adminresource = _mapper.Map<AcompannantePaciente, AcompannanteResource>(acompannante.Acompannante);
            return Ok(adminresource);
        }

    }
}
