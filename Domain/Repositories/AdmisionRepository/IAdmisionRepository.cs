using ECHO_API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Domain.Repositories.AdmisionRepository
{
    public interface IAdmisionRepository
    {
        Task<IEnumerable<Admision>> ListAsync();

        //Task AddAsync(Pacientes pacientes);

        Task<Admision> FindByIdAsync(int id);

        void Update(Admision admision);

        // void Remove(Admision admision);
    }
}
