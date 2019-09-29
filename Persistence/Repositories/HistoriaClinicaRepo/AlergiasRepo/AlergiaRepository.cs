using ECHO_API.Domain.Models;
using ECHO_API.Domain.Repositories.HistoriaClinicaRepository.AlergiasRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Persistence.Repositories.HistoriaClinicaRepo.AlergiasRepo
{
    public class AlergiaRepository : IAlergiasRepository
    {
        public Task AddAsync(Alergias historiaClinica)
        {
            throw new NotImplementedException();
        }

        public Task<Alergias> FindByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Alergias>> ListAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(Alergias admision)
        {
            throw new NotImplementedException();
        }
    }
}
