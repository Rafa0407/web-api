using ECHO_API.Domain.Models;
using ECHO_API.Domain.Repositories.PacientesRepository;
using ECHO_API.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Persistence.Repositories.PacientesRepository
{
    public class PacientesRepository : BaseRepository, IPacienteRepository
    {
        public PacientesRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Pacientes>> ListAsync()
        {
            return await _context.Pacientes.ToListAsync();
        }

        public async Task<Pacientes> FindByIdAsync(string identificacion)
        {

            var paciente = _context.Pacientes.Where(p => p.Identificacion == identificacion)
                                              .Include(p => p.DatosPadresNavigation)
                                              .SingleOrDefaultAsync();
            return await paciente;
        }

        /*public async Task AddAsync(Pacientes pacientes)
        {
            await _context.Pacientes.AddAsync(pacientes);
        }

  

        public void Update(Pacientes pacientes)
        {
            _context.Pacientes.Update(pacientes);
        }

        public void Remove(Pacientes pacientes)
        {
            _context.Pacientes.Remove(pacientes);
        }*/
    }
}
