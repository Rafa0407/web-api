using ECHO_API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Domain.Repositories.HistoriaClinicaRepository
{
    public interface IHistoriaClinicaRepository
    {
        Task<IEnumerable<HistoriaClinica>> ListAsync();

        Task AddAsync(HistoriaClinica historiaClinica);

        Task<HistoriaClinica> FindByIdAsync(int? id);

        void Update(HistoriaClinica admision);

        // void Remove(Admision admision);
    }
}
