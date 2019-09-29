using ECHO_API.Domain.Models;
using ECHO_API.Domain.Services.HistoriaClinicaService.TiposAlergiaService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Services
{
    public class TiposAlergiaService : ITiposAlergiasService
    {
        public Task<TipoAlergias> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TipoAlergias>> ListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TipoAlergias> RemoveAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TipoAlergias> SaveAsync(TipoAlergias tipoAlergias)
        {
            throw new NotImplementedException();
        }

        public Task<TipoAlergias> UpdateAsync(int id, TipoAlergias tipoAlergias)
        {
            throw new NotImplementedException();
        }
    }
}
