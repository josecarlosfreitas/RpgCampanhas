﻿using Microsoft.EntityFrameworkCore;
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
                return await _context.Campanhas.Where(c => c.MestreId == mestreId).ToListAsync();
            }
      }
}
