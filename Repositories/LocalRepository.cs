using Microsoft.EntityFrameworkCore;
using RpgCampanhas.Data;
using RpgCampanhas.Models;
using RpgCampanhas.Repositories.Interfaces;

namespace RpgCampanhas.Repositories
{
      public class LocalRepository : BaseRepository<Local>, ILocalRepository
    {
            public LocalRepository(AppDbContext context) : base(context)
            {
            }

            public async Task<IEnumerable<Local>> GetByCampanhaId(long campanhaId)
            {
                return await _context.Locais.Where(c => c.CampanhaId == campanhaId).ToListAsync();
            }
      }
}
