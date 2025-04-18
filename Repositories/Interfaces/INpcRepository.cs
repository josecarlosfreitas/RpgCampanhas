using RpgCampanhas.Models;

namespace RpgCampanhas.Repositories.Interfaces
{
    public interface INpcRepository : IBaseRepository<NPC>
    {
        Task<IEnumerable<NPC>> GetByCampanhaId(long campanhaId);
    }
}
