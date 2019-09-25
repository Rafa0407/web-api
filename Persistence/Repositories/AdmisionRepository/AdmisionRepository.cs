using ECHO_API.Domain.Models;
using ECHO_API.Domain.Repositories.AdmisionRepository;
using ECHO_API.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Persistence.Repositories.AdmisionRepository
{
    public class AdmisionRepository : BaseRepository, IAdmisionRepository
    {
        public AdmisionRepository(AppDbContext context) : base(context)
        { }

        public async Task<IEnumerable<Admision>> ListAsync()
        {
            return await _context.Admision.Include(a => a.AcompannantePaciente)
                                          .Include(a => a.CreadoPorNavigation)
                                          .Include(a => a.InternamientoNavigation)
                                          .ToListAsync();
        }

        public async Task<Admision> FindByIdAsync(int? id)
        {
            return await _context.Admision.Where(a => a.Internamiento == id)
                                          .Include(a => a.AcompannantePaciente)
                                          .Include(a => a.CreadoPorNavigation)
                                          .Include(a => a.InternamientoNavigation)
                                          .FirstOrDefaultAsync();
                                     
        }

        public async Task AddAsync(Admision admision)
        {
            await _context.Admision.AddAsync(admision);
        }
        public void Update(Admision admision)
        {
            _context.Admision.Update(admision);
        }

    }
}
