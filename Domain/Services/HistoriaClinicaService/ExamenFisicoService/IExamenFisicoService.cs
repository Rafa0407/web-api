using ECHO_API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Domain.Services.HistoriaClinicaService.ExamenFisicoService
{
    public interface IExamenFisicoService
    {
        Task<IEnumerable<ExamenFisico>> ListAsync();
        Task<ExamenFisico> FindByIdAsync(int id);
        Task<ExamenFisico> SaveAsync(ExamenFisico examenFisico);
        Task<ExamenFisico> UpdateAsync(int id, ExamenFisico examenFisico);
    }
}
