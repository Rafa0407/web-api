using ECHO_API.Domain.Models;
using ECHO_API.Domain.Repositories.CostarricensesBusquedaRepo;
using ECHO_API.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Persistence.Repositories.CostarricensesRepository
{
    public class CostarrincesesRepository : BaseRepository,  ICostarricensesBusqueda
    {
        public CostarrincesesRepository (AppDbContext contex) : base(contex)  { }
        public async Task<CostarricensesBusqueda> FindByIdAsync(int id)
        {
            return await _context.CostarricensesBusqueda.FromSql($"SELECT * FROM Costarricenses_NombresCompletos WHERE CedulaIdentidad = {id}")
                                                        .SingleOrDefaultAsync();
        }
    }
}
