using Microsoft.EntityFrameworkCore;
using RpgCampanhas.Data;
using RpgCampanhas.Models;
using RpgCampanhas.Repositories.Interfaces;

namespace RpgCampanhas.Repositories
{
      public class NpcRepository : BaseRepository<NPC>, INpcRepository
      {
            public NpcRepository(AppDbContext context) : base(context)
            {
            }

            public async Task<IEnumerable<NPC>> GetByCampanhaId(long campanhaId)
            {
                return await _context.NPCs.Where(c => c.CampanhaId == campanhaId).ToListAsync();
            }
      }
}
