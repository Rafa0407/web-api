using ECHO_API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Domain.Repositories.HistoriaClinicaRepository.AlergiasRepo
{
    public interface IAlergiasRepository
    {
        Task<IEnumerable<Alergias>> ListAsync();

        Task AddAsync(Alergias historiaClinica);

        Task<Alergias> FindByIdAsync(int? id);

        void Update(Alergias admision);
    }
}
