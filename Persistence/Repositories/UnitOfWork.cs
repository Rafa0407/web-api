using ECHO_API.Domain.Repositories;
using ECHO_API.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*
 Unit of Work Pattern. This pattern consists of a class that receives 
 our AppDbContext instance as a dependency and exposes methods to start, complete or abort transactions. 
*/
namespace ECHO_API.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
