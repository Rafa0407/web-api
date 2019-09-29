using ECHO_API.Domain.Models;
using ECHO_API.Domain.Services.Communication.HistoriaClinicResponse;
using ECHO_API.Domain.Services.HistoriaClinicaService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Services
{
    public class HistoriaClinicaService : IHistoriaClinicaService
    {
        public Task<HistoriaClinica> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<HistoriaClinica>> ListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<HistoriaClinicaResponse> SaveAsync(HistoriaClinica historiaClinica)
        {
            throw new NotImplementedException();
        }

        public Task<HistoriaClinicaResponse> UpdateAsync(int id, HistoriaClinica historiaClinica)
        {
            throw new NotImplementedException();
        }
    }
}
