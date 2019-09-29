using ECHO_API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Domain.Services.HistoriaClinicaService.TiposAlergiaService
{
    public interface ITiposAlergiasService
    {
        Task<IEnumerable<TipoAlergias>> ListAsync();
        Task<TipoAlergias> FindByIdAsync(int id);
        Task<TipoAlergias> SaveAsync(TipoAlergias tipoAlergias);
        Task<TipoAlergias> UpdateAsync(int id, TipoAlergias tipoAlergias);
        Task<TipoAlergias> RemoveAsync(int id);
    }
}
