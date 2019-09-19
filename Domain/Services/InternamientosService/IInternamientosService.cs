using ECHO_API.Domain.Models;
using ECHO_API.Domain.Services.Communication.InternamientosResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Domain.Services.InternamientosService
{
    public interface IInternamientosService
    {
        // CRUD METHOD DECLARATION
        Task<IEnumerable<Internamientos>> ListAsync();
        //Task AddAsync(Pacientes pacientes);

        Task<Internamientos> FindByIdAsync(int id);

        Task<InternamientosResponse> UpdateAsync(Internamientos internamiento);

        //Task>InternamientosResponse> RemoveAsync(Internamientos internamiento);
    }
}
