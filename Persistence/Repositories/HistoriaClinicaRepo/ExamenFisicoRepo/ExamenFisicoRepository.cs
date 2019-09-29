using ECHO_API.Domain.Models;
using ECHO_API.Domain.Repositories.HistoriaClinicaRepository.ExamenFisicoRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Persistence.Repositories.HistoriaClinicaRepo.ExamenFisicoRepo
{
    public class ExamenFisicoRepository : IExamenFisicoRepository
    {
        public Task AddAsync(ExamenFisico historiaClinica)
        {
            throw new NotImplementedException();
        }

        public Task<ExamenFisico> FindByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ExamenFisico>> ListAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(ExamenFisico admision)
        {
            throw new NotImplementedException();
        }
    }
}
