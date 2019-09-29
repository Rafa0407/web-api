using ECHO_API.Domain.Models;
using ECHO_API.Domain.Services.HistoriaClinicaService.AlergiasService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Services
{
    public class AlergiasService : IAlergiaService
    {
        public Task<Alergias> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Alergias>> ListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Alergias> SaveAsync(Alergias alergias)
        {
            throw new NotImplementedException();
        }

        public Task<Alergias> UpdateAsync(int id, Alergias alergias)
        {
            throw new NotImplementedException();
        }
    }
}
