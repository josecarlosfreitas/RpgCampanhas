using Microsoft.EntityFrameworkCore;
using RpgCampanhas.Data;
using RpgCampanhas.Models;
using RpgCampanhas.Repositories.Interfaces;

namespace RpgCampanhas.Repositories
{
      public class HistoriaRepository : BaseRepository<Historia>, IHistoriaRepository
    {
            public HistoriaRepository(AppDbContext context) : base(context)
            {
            }

            public async Task<IEnumerable<Historia>> GetByCampanhaId(long campanhaId)
            {
                return await _context.Historias.Where(c => c.CampanhaId == campanhaId).ToListAsync();
            }
      }
}
