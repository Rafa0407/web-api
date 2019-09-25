using ECHO_API.Domain.Models;
using ECHO_API.Domain.Repositories.InternamientosRepository;
using ECHO_API.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Persistence.Repositories.InternamientosRepository
{
    public class InternamientosRepository : BaseRepository, IInternamientosRepository
    {
        public InternamientosRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Internamientos>> ListAsync()
        {
            return await _context.Internamientos .Where(p =>  p.EstadoInternamiento == true) // solo los internamientos activos
                                                  .Include(inter => inter.CreadoPorNavigation)
                                                  .Include(inter => inter.PacienteInternamientoNavigation)
                                                  .Include(inter => inter.PersonalInternamiento)
                                                  .ThenInclude(f => f.IdFuncionNavigation)
                                                  .Include(inter => inter.PersonalInternamiento)
                                                  .ThenInclude(m => m.IdMedicoNavigation)
                                                 .ToListAsync();
        }

        public async Task<Internamientos> FindByIdAsync(int id)
        {

            return await _context.Internamientos.Where(inter => inter.IdInternamiento == id && inter.EstadoInternamiento == true)
                                                  .Include(inter => inter.CreadoPorNavigation)
                                                  .Include(inter => inter.PacienteInternamientoNavigation)
                                                  .Include(inter => inter.PersonalInternamiento)
                                                  .ThenInclude(f => f.IdFuncionNavigation)
                                                  .Include(inter => inter.PersonalInternamiento)
                                                  .ThenInclude(m => m.IdMedicoNavigation)
                                                .FirstOrDefaultAsync(); 
        }

        /*public async Task AddAsync(Pacientes pacientes)
        {
            await _context.Pacientes.AddAsync(pacientes);
        }
        */
  

        public void Update(Internamientos internamientos)
        {
            _context.Internamientos.Update(internamientos);
        }

        /*public void Remove(Pacientes pacientes)
        {
            _context.Pacientes.Remove(pacientes);
        }*/
    }
}
