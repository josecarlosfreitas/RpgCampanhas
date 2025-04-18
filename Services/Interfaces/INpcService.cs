using RpgCampanhas.Models;

namespace RpgCampanhas.Services.Interfaces
{
    public interface INpcService : IBaseService<NPC>
    {
        Task<IEnumerable<NPC>> GetByCampanhaId(long campanhaId);
    }
}
