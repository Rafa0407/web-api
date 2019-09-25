using AutoMapper;
using ECHO_API.Domain.Models;
using ECHO_API.Domain.Services.AdmisionService;
using ECHO_API.Extensions;
using ECHO_API.Resources.AdmisionResource;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Controllers
{
    [Route("/api/[controller]")]
    public class AdmisionController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IAdmisionService _admisionService;

        public AdmisionController(IMapper mapper, IAdmisionService admisionService)
        {
            _mapper = mapper;
            _admisionService = admisionService;
        }

        [HttpGet]
        public async Task<IEnumerable<AdmisionResource>> GetAllAsync()
        {
            var admisiones = await _admisionService.ListAsync();
            var admresource = _mapper.Map<IEnumerable<Admision>, IEnumerable<AdmisionResource>>(admisiones);
            return admresource;
        }

        [HttpGet("{id}")]
        public async Task<AdmisionResource> GetGetByIdAsync(int id)
        {
            var admision = await _admisionService.FindByIdAsync(id);
            var admresource = _mapper.Map<Admision, AdmisionResource>(admision);
            return admresource;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SaveAdmisionResource saveAdmisionResource)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { message = ModelState.GetErrorMessages()});

            var admision = _mapper.Map<SaveAdmisionResource, Admision>(saveAdmisionResource);
            var admresult = await _admisionService.SaveAsync(admision);

            if (!admresult.Success)
                return BadRequest(new { message = admresult.Message });

            var admiResource = _mapper.Map<Admision, AdmisionResource>(admresult.Admision);
            return Ok(admiResource);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync([FromBody] UpdateAdmisionResource updateAdmisionResource) 
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());
            var admision = _mapper.Map<UpdateAdmisionResource, Admision>(updateAdmisionResource);
            var admiResult = await _admisionService.UpdateAsync(admision);

            if (!admiResult.Success)
                return BadRequest(admiResult.Message);

            var admisionResource = _mapper.Map<Admision, AdmisionResource>(admiResult.Admision);
            return Ok(admisionResource);
        }

    }
}
