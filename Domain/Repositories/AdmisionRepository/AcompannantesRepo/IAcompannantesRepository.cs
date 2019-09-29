using ECHO_API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Domain.Repositories.AdmisionRepository.AcompannantesRepo
{
    public interface IAcompannantesRepository
    {
        Task<IEnumerable<AcompannantePaciente>> ListAsync();

        Task AddAsync(AcompannantePaciente admision);

        Task<AcompannantePaciente> FindByIdAsync(int id);

        void Update(AcompannantePaciente acompannantePaciente);

        void Remove(AcompannantePaciente acompannantePaciente);
    }
}
