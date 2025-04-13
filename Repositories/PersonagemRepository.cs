﻿using Microsoft.EntityFrameworkCore;
using RpgCampanhas.Data;
using RpgCampanhas.Models;
using RpgCampanhas.Repositories.Interfaces;

namespace RpgCampanhas.Repositories
{
      public class PersonagemRepository : BaseRepository<Personagem>, IPersonagemRepository
      {
            public PersonagemRepository(AppDbContext context) : base(context)
            {
            }

            public async Task<IEnumerable<Personagem>> GetByCampanhaId(long campanhaId)
            {
                return await _context.Personagens.Include(p => p.Jogador).Where(c => c.CampanhaId == campanhaId).ToListAsync();
            }
      }
}
