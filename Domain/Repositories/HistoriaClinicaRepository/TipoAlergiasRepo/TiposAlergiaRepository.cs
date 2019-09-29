using ECHO_API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Domain.Repositories.HistoriaClinicaRepository.TipoAlergiasRepo
{
    public interface ITiposAlergiaRepository
    {
        Task<IEnumerable<TipoAlergias>> ListAsync();

        Task AddAsync(TipoAlergias historiaClinica);

        Task<TipoAlergias> FindByIdAsync(int? id);

        void Update(TipoAlergias admision);
        void Remove(TipoAlergias admision);
    }
}
