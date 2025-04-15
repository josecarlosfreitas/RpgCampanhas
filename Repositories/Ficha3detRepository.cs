using Microsoft.EntityFrameworkCore;
using RpgCampanhas.Data;
using RpgCampanhas.Models;
using RpgCampanhas.Repositories.Interfaces;

namespace RpgCampanhas.Repositories
{
      public class Ficha3detRepository : BaseRepository<Ficha3det>, IFicha3detRepository
      {
            public Ficha3detRepository(AppDbContext context) : base(context)
            {
            }

            public async Task<IEnumerable<Ficha3det>> GetByPersonagemId(long personagemId)
            {
                return await _context.Ficha3Dets
                                .Include(p => p.Personagem)
                                .Where(c => c.PersonagemId == personagemId).ToListAsync();
            }

            public async Task<IEnumerable<Ficha3det>> GetByNpcId(long npcId)
            {
                return await _context.Ficha3Dets
                                .Include(p => p.Npc)
                                .Where(c => c.NpcId == npcId).ToListAsync();
            }
      }
}
