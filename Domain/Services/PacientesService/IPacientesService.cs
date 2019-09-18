using ECHO_API.Domain.Models;
using ECHO_API.Domain.Services.Communication.PacientesResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Domain.Services.PacientesService
{
    public interface IPacientesService
    {
        Task<IEnumerable<Pacientes>> ListAsync();
        Task<PacientesResponse> FindByIdAsync(string identificacion);
        /*Task<CategoryResponse> SaveAsync(Category category);
        Task<CategoryResponse> UpdateAsync(int id, Category category);
        Task<CategoryResponse> DeleteAsync(int id);*/
    }
}
