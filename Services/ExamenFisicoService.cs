using ECHO_API.Domain.Models;
using ECHO_API.Domain.Services.HistoriaClinicaService.ExamenFisicoService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Services
{
    public class ExamenFisicoService : IExamenFisicoService
    {
        public Task<ExamenFisico> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ExamenFisico>> ListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ExamenFisico> SaveAsync(ExamenFisico examenFisico)
        {
            throw new NotImplementedException();
        }

        public Task<ExamenFisico> UpdateAsync(int id, ExamenFisico examenFisico)
        {
            throw new NotImplementedException();
        }
    }
}
