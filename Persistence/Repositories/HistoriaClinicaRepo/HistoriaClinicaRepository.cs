using ECHO_API.Domain.Models;
using ECHO_API.Domain.Repositories.HistoriaClinicaRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Persistence.Repositories.HistoriaClinicaRepo
{
    public class HistoriaClinicaRepository : IHistoriaClinicaRepository
    {
        public Task AddAsync(HistoriaClinica historiaClinica)
        {
            throw new NotImplementedException();
        }

        public Task<HistoriaClinica> FindByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<HistoriaClinica>> ListAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(HistoriaClinica admision)
        {
            throw new NotImplementedException();
        }
    }
}
