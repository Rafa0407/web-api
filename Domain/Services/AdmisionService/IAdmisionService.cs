using ECHO_API.Domain.Models;
using ECHO_API.Domain.Services.Communication.AdmisionResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Domain.Services.AdmisionService
{
    public interface IAdmisionService
    {
        Task<IEnumerable<Admision>> ListAsync();
        Task<Admision> FindByIdAsync(int? id);
        Task<AdmisionResponse> SaveAsync(Admision admision);
        Task<AdmisionResponse> UpdateAsync(Admision admision);

        //Task>AdmisionResponse> RemoveAsync(Admision admision); // i do not develop for cowards... just for brave people 
    }
}
