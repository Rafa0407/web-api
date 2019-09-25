using ECHO_API.Domain.Models;
using ECHO_API.Domain.Repositories;
using ECHO_API.Domain.Repositories.AdmisionRepository;
using ECHO_API.Domain.Services.AdmisionService;
using ECHO_API.Domain.Services.Communication.AdmisionResponse;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Services
{
    public class AdmisionService : IAdmisionService 
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAdmisionRepository _admisionRepository;

        public AdmisionService(IUnitOfWork unitOfWork, IAdmisionRepository admisionRepository)
        {
            _unitOfWork = unitOfWork;
            _admisionRepository = admisionRepository;
        }

        public async Task<Admision> FindByIdAsync(int? id)
        {
            return await _admisionRepository.FindByIdAsync(id);
        }

        public async Task<IEnumerable<Admision>> ListAsync()
        {
            return await _admisionRepository.ListAsync();
        }

        public async Task<AdmisionResponse> SaveAsync(Admision admision)
        {
            var existsAdmision = await _admisionRepository.FindByIdAsync(admision.Internamiento);

            if (existsAdmision != null)
                return new AdmisionResponse("El internamiento ya cuenta con una admision en curso");

            try
            {
                await _admisionRepository.AddAsync(admision);
                await _unitOfWork.CompleteAsync();
                return new AdmisionResponse(admision);

            }
            catch (Exception ex)
            {
                return new AdmisionResponse($"An error occurred when saving the category: {ex.Message}");
            }
        }

        public async Task<AdmisionResponse> UpdateAsync(Admision admision)
        {
            var existsAdmision = await _admisionRepository.FindByIdAsync(admision.Internamiento);

            if (existsAdmision == null)
                return new AdmisionResponse("La admision no corresponde a ningun internamiento");


            existsAdmision.DiagnosticoIngreso = admision.DiagnosticoIngreso;
            existsAdmision.FechaIngreso = admision.FechaIngreso;
            existsAdmision.FechaIngreso = admision.FechaIngreso;

            try
            {
                _admisionRepository.Update(existsAdmision);
                await _unitOfWork.CompleteAsync();

                return new AdmisionResponse(existsAdmision);
            }
            catch (SqlException sq)
            {
                return new AdmisionResponse($"An error ocurred: {sq.Message}");
            }

        }
    }
}
