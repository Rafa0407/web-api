using ECHO_API.Domain.Models;
using ECHO_API.Domain.Repositories.AdmisionRepository.AcompannantesRepo;
using ECHO_API.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Persistence.Repositories.AdmisionRepository.AcomppananteRepo
{
    public class AcompannanteRepository : BaseRepository, IAcompannantesRepository
    {
        public AcompannanteRepository(AppDbContext context) : base(context) { }

        public async Task<IEnumerable<AcompannantePaciente>> ListAsync()
        {
            return await _context.AcompannantePaciente.ToListAsync();
        }

        public async Task<AcompannantePaciente> FindByIdAsync(int id)
        {
            return await _context.AcompannantePaciente
                                        .Where(ac => ac.IdAcompannante == id)
                                        .FirstOrDefaultAsync();
        }
        public async Task AddAsync(AcompannantePaciente acompannante)
        {
            await _context.AcompannantePaciente.AddAsync(acompannante);
        }
        public void Remove(AcompannantePaciente acompannante)
        {
            _context.AcompannantePaciente.Remove(acompannante);
        }

        public void Update(AcompannantePaciente acompannante)
        {
            _context.AcompannantePaciente.Update(acompannante);
        }
    }
}
