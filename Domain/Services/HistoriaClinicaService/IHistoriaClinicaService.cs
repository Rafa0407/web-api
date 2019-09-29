using ECHO_API.Domain.Models;
using ECHO_API.Domain.Services.Communication.HistoriaClinicResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Domain.Services.HistoriaClinicaService
{
    public interface IHistoriaClinicaService
    {
        Task<IEnumerable<HistoriaClinica>> ListAsync();
        Task<HistoriaClinica> FindByIdAsync(int id);
        Task<HistoriaClinicaResponse> SaveAsync(HistoriaClinica historiaClinica);
        Task<HistoriaClinicaResponse> UpdateAsync(int id, HistoriaClinica historiaClinica);
    }
}
