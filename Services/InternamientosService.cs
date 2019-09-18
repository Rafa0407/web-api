using ECHO_API.Domain.Models;
using ECHO_API.Domain.Repositories;
using ECHO_API.Domain.Repositories.InternamientosRepository;
using ECHO_API.Domain.Services.Communication.InternamientosResponse;
using ECHO_API.Domain.Services.InternamientosService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Services
{
    public class InternamientosService : IInternamientosService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IInternamientosRepository _internamientosRepository;

        public InternamientosService(IUnitOfWork unitOfWork, IInternamientosRepository internamientosRepository)
        {
            _unitOfWork = unitOfWork;
            _internamientosRepository = internamientosRepository;
        }

        public async Task<IEnumerable<Internamientos>> ListAsync()
        {
            return await _internamientosRepository.ListAsync();
        }
        public async Task<InternamientosResponse> FindByIdAsync(int id)
        {
            try
            {
                await _unitOfWork.CompleteAsync();
                var internamiento = await _internamientosRepository.FindByIdAsync(id);
                return new InternamientosResponse(internamiento);
            }
            catch (Exception ex)
            {
                return new InternamientosResponse($"Internamiento not found. {ex}");
            }

        }

        public void Update(Internamientos internamiento)
        {
            throw new NotImplementedException();
        }
    }
}
