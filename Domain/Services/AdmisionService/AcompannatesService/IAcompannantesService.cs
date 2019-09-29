using ECHO_API.Domain.Models;
using ECHO_API.Domain.Services.Communication.AdmisionResponse.AcompannantesResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Domain.Services.AdmisionService.AcompannatesService
{
    public interface IAcompannantesService
    {
        Task<IEnumerable<AcompannantePaciente>> ListAsync();
        Task<AcompannantePaciente> FindByIdAsync(int id);
        Task<AcompResponse> SaveAsync(AcompannantePaciente acompannante);
        Task<AcompResponse> UpdateAsync(int id, AcompannantePaciente acompannante);
        Task<AcompResponse> RemoveAsync(int id); 
    }
}
