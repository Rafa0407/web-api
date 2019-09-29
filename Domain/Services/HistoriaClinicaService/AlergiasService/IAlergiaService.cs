using ECHO_API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Domain.Services.HistoriaClinicaService.AlergiasService
{
    public interface IAlergiaService
    {
        Task<IEnumerable<Alergias>> ListAsync();
        Task<Alergias> FindByIdAsync(int id);
        Task<Alergias> SaveAsync(Alergias alergias);
        Task<Alergias> UpdateAsync(int id, Alergias alergias);
    }
}
