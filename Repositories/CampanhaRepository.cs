using Microsoft.EntityFrameworkCore;
using RpgCampanhas.Data;
using RpgCampanhas.Models;
using RpgCampanhas.Repositories.Interfaces;

namespace RpgCampanhas.Repositories
{
      public class CampanhaRepository : BaseRepository<Campanha>, ICampanhaRepository
      {
            public CampanhaRepository(AppDbContext context) : base(context)
            {
            }

            public override async Task<IEnumerable<Campanha>> GetAll()
            {
                return await _context.Campanhas
                .Include(c => c.Mestre)
                .ToListAsync();
            }

            public async Task<IEnumerable<Campanha>> GetByMestreId(long mestreId)
            {
                return await _context.Campanhas.Include(c => c.Mestre).Where(c => c.MestreId == mestreId).ToListAsync();
            }

            public async Task<IEnumerable<Campanha>> GetByUsuario(long usuarioId)
            {
                return await _context.Campanhas
                    .Include(c => c.Personagens)
                    .Where(c => c.Personagens.Any(p => p.JogadorId == usuarioId))
                    .ToListAsync();
            }
      }
}
