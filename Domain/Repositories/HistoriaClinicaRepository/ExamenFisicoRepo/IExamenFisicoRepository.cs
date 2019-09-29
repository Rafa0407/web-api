using ECHO_API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Domain.Repositories.HistoriaClinicaRepository.ExamenFisicoRepo
{
    public interface IExamenFisicoRepository
    {
        Task<IEnumerable<ExamenFisico>> ListAsync();

        Task AddAsync(ExamenFisico historiaClinica);

        Task<ExamenFisico> FindByIdAsync(int? id);

        void Update(ExamenFisico admision);
    }
}
