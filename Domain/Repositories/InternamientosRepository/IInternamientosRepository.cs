using ECHO_API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Domain.Repositories.InternamientosRepository
{
    public interface IInternamientosRepository
    {
        // CRUD METHOD DECLARATION
        Task<IEnumerable<Internamientos>> ListAsync();

        //Task AddAsync(Pacientes pacientes);

        Task<Internamientos> FindByIdAsync(int id);

        void Update(Internamientos internamiento);

        // void Remove(Internamientos internamiento);
    }
}
