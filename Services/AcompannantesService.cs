using ECHO_API.Domain.Models;
using ECHO_API.Domain.Repositories;
using ECHO_API.Domain.Repositories.AdmisionRepository.AcompannantesRepo;
using ECHO_API.Domain.Services.AdmisionService.AcompannatesService;
using ECHO_API.Domain.Services.Communication.AdmisionResponse.AcompannantesResponse;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace ECHO_API.Services
{
    public class AcompannantesService : IAcompannantesService 
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAcompannantesRepository _acompannantesRepository;

        public AcompannantesService(IUnitOfWork unitOfWork, IAcompannantesRepository acompannantesRepository)
        {
            _unitOfWork = unitOfWork;
            _acompannantesRepository = acompannantesRepository;
        }

        public async Task<AcompannantePaciente> FindByIdAsync(int id)
        {
            return await _acompannantesRepository.FindByIdAsync(id);
        }

        public async Task<IEnumerable<AcompannantePaciente>> ListAsync()
        {
            return await _acompannantesRepository.ListAsync();
        }

        public async Task<AcompResponse> SaveAsync(AcompannantePaciente acompannante)
        {
            var existsacompannante = await _acompannantesRepository.FindByIdAsync(acompannante.IdAcompannante);

            if (existsacompannante.Identificacion == acompannante.Identificacion)
                return new AcompResponse("El acompañante ya se encuentra registrado, intente de nuevo");

            try
            {
                await _acompannantesRepository.AddAsync(acompannante);
                await _unitOfWork.CompleteAsync();
                return new AcompResponse(acompannante);

            }
            catch (SqlException ex)
            {
                return new AcompResponse($"Ha ocurrido un error mientras se guardaban los acompañantes: {ex.Message}");
            }
        }

        public async Task<AcompResponse> RemoveAsync(int id)
        {
            var existsacompannante = await _acompannantesRepository.FindByIdAsync(id);

            if (existsacompannante == null)
                return new AcompResponse("El acompañante no existe");

            try
            {
                _acompannantesRepository.Remove(existsacompannante);
                await _unitOfWork.CompleteAsync();

                return new AcompResponse(existsacompannante);
            }
            catch (Exception sq)
            {
                return new AcompResponse($"An error ocurred: {sq.Message}");
            }
        }

        public async Task<AcompResponse> UpdateAsync(int id, AcompannantePaciente acompannante)

        {
            var existsacompannante = await _acompannantesRepository.FindByIdAsync(id);

            if (existsacompannante == null)
                return new AcompResponse("El acompañante no existe");

            existsacompannante.Identificacion = acompannante.Identificacion;
            existsacompannante.NombreAcompañante = acompannante.NombreAcompañante;
            existsacompannante.Telefono = acompannante.Telefono;

            try
            {
                _acompannantesRepository.Update(existsacompannante);
                await _unitOfWork.CompleteAsync();

                return new AcompResponse(existsacompannante);
            }
            catch (Exception sq)
            {
                return new AcompResponse($"ha ocurrido un error: {sq.Message}");
            }
        }
    }
}
