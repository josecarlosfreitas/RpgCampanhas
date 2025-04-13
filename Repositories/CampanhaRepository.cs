using Microsoft.EntityFrameworkCore;
using RpgCampanhas.Data;
using RpgCampanhas.Models;
using RpgCampanhas.Repositories.Interfaces;

namespace RpgCampanhas.Repositories
{
      public class CampanhaRepository : ICampanhaRepository
      {
            private readonly AppDbContext _context;

            public CampanhaRepository(AppDbContext context)
            {
                _context = context;
            }

            public async Task<Campanha> GetById(long id)
            {
                return await _context.Campanhas.FindAsync(id);
            }

            public async Task<IEnumerable<Campanha>> GetAll()
            {
                return await _context.Campanhas.ToListAsync();
            }

            public async Task<Campanha> Add(Campanha model)
            {
                _context.Campanhas.Add(model);
                await _context.SaveChangesAsync();
                return model;
            }

            public async Task<Campanha> Update(Campanha model)
            {
                _context.Entry(model).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return model;
            }

            public async Task Delete(long id)
            {
                var campanha = await _context.Campanhas.FindAsync(id);
                if (campanha != null)
                {
                    _context.Campanhas.Remove(campanha);
                    await _context.SaveChangesAsync();
                }
            }

            public async Task<IEnumerable<Campanha>> GetByMestreId(long mestreId)
            {
                return await _context.Campanhas.Where(c => c.MestreId == mestreId).ToListAsync();
            }
      }
}
