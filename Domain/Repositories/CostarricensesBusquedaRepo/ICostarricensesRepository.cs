using ECHO_API.Domain.Models;
using System.Threading.Tasks;

namespace ECHO_API.Domain.Repositories.CostarricensesBusquedaRepo
{
    public interface ICostarricensesBusqueda
    {
        Task<CostarricensesBusqueda> FindByIdAsync(int identificacion);
    }
}
