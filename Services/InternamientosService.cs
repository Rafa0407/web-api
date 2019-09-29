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
        public async Task<Internamientos> FindByIdAsync(int id)
        {
            await _unitOfWork.CompleteAsync();
            var internamiento = await _internamientosRepository.FindByIdAsync(id);
            return internamiento;
        }


        public async Task<InternamientosResponse> UpdateAsync(Internamientos internamiento)
        {
            var existingInternamiento = await _internamientosRepository.FindByIdAsync(internamiento.IdInternamiento);

            if(existingInternamiento == null)
                return new InternamientosResponse("Internamiento not found");

            if (existingInternamiento.EstadoInternamiento == false)
                return new InternamientosResponse("El internamiento ya está inactivo"); 

            existingInternamiento.EstadoInternamiento = internamiento.EstadoInternamiento; 

            try
            {
                _internamientosRepository.Update(existingInternamiento);
                await _unitOfWork.CompleteAsync();

                return new InternamientosResponse(existingInternamiento);
            }
            catch (Exception ex)
            {
                return new InternamientosResponse($"Ha ocurrido un error mientras se actualizaban los datos: {ex.Message}");
            }

        }
    }
}
