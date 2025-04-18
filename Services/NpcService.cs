using RpgCampanhas.Models;
using RpgCampanhas.Repositories.Interfaces;
using RpgCampanhas.Services.Interfaces;

namespace RpgCampanhas.Services
{
    public class NpcService : BaseService<NPC>, INpcService
    {
        private readonly INpcRepository _npcRepository;

        public NpcService(INpcRepository npcRepository)
            : base(npcRepository)
        {
            _npcRepository = npcRepository;
        }

        
        public Task<IEnumerable<NPC>> GetByCampanhaId(long campanhaId)
        {
            return _npcRepository.GetByCampanhaId(campanhaId);
        }
    }
}
