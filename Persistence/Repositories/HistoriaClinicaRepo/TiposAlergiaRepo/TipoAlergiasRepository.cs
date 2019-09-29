using ECHO_API.Domain.Models;
using ECHO_API.Domain.Repositories.HistoriaClinicaRepository.TipoAlergiasRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Persistence.Repositories.HistoriaClinicaRepo.TiposAlergiaRepo
{
    public class TiposAlergiaRepository : ITiposAlergiaRepository
    {
        public Task AddAsync(TipoAlergias historiaClinica)
        {
            throw new NotImplementedException();
        }

        public Task<TipoAlergias> FindByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TipoAlergias>> ListAsync()
        {
            throw new NotImplementedException();
        }

        public void Remove(TipoAlergias admision)
        {
            throw new NotImplementedException();
        }

        public void Update(TipoAlergias admision)
        {
            throw new NotImplementedException();
        }
    }
}
