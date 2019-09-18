using ECHO_API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Domain.Repositories.PacientesRepository
{
    public interface IPacienteRepository
    {
        // CRUD METHOD DECLARATION
        Task<IEnumerable<Pacientes>> ListAsync();
        //Task AddAsync(Pacientes pacientes);

        Task<Pacientes> FindByIdAsync(string identificacion);

        //void Update(Pacientes category);

        //void Remove(Pacientes category);
    }
}
