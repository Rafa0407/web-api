using ECHO_API.Domain.Models;
using ECHO_API.Domain.Repositories;
using ECHO_API.Domain.Repositories.PacientesRepository;
using ECHO_API.Domain.Services.Communication.PacientesResponse;
using ECHO_API.Domain.Services.PacientesService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Services
{
    public class PacientesService : IPacientesService
    {
        private readonly IPacienteRepository _pacientesRepository;

        private readonly IUnitOfWork _unitOfWork;

        public PacientesService(IUnitOfWork unitOfWork, IPacienteRepository pacienteRepository)
        {
            _unitOfWork = unitOfWork;
            _pacientesRepository = pacienteRepository;
        }
        public async Task<IEnumerable<Pacientes>> ListAsync()
        {
            return await _pacientesRepository.ListAsync();
        }

        public async Task<PacientesResponse> FindByIdAsync(string identificacion)
        {
            try
            {
                await _unitOfWork.CompleteAsync();
                var paciente = await _pacientesRepository.FindByIdAsync(identificacion);
                return new PacientesResponse(paciente);
            }
            catch (Exception ex)
            {
                return new PacientesResponse($"Paciente not found. {ex}");
            }
        }

    }
}
