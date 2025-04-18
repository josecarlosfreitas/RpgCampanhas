using RpgCampanhas.Models;

namespace RpgCampanhas.Repositories.Interfaces
{
    public interface IHistoriaRepository : IBaseRepository<Historia>
    {
        Task<IEnumerable<Historia>> GetByCampanhaId(long campanhaId);
    }
}
