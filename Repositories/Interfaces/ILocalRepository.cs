using RpgCampanhas.Models;

namespace RpgCampanhas.Repositories.Interfaces
{
    public interface ILocalRepository : IBaseRepository<Local>
    {
        Task<IEnumerable<Local>> GetByCampanhaId(long campanhaId);
    }
}
