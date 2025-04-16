using RpgCampanhas.Data;
using RpgCampanhas.Repositories.Interfaces;

namespace RpgCampanhas.Repositories
{
    public class GenericRepository : IGenericRepository
    {
        private readonly AppDbContext _context;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task UpdatePersonagemImageAsync(string personagemId, string imagePath)
        {
            if (long.TryParse(personagemId, out var personagemIdLong))
            {
                var personagem = await _context.Personagens.FindAsync(personagemIdLong);
                if (personagem != null)
                {
                    personagem.ImagePath = imagePath;
                    await _context.SaveChangesAsync();
                }
            }
        }

        public async Task UpdateFicha3detImageAsync(string ficha3detId, string imagePath)
        {
            if (long.TryParse(ficha3detId, out var ficha3detIdLong))
            {
                var ficha3det = await _context.Ficha3Dets.FindAsync(ficha3detIdLong);
                if (ficha3det != null)
                {
                    ficha3det.ImagePath = imagePath;
                    await _context.SaveChangesAsync();
                }
            }
        }

        public async Task UpdateCampanhaImageAsync(string campanhaId, string imagePath)
        {
            if (long.TryParse(campanhaId, out var campanhaIdLong))
            {
                var campanha = await _context.Campanhas.FindAsync(campanhaIdLong);
                if (campanha != null)
                {
                    campanha.ImagePath = imagePath;
                    await _context.SaveChangesAsync();
                }
            }
        }

        public async Task UpdateNpcImageAsync(string npcId, string imagePath)
        {
            if (long.TryParse(npcId, out var npcIdLong))
            {
                var npc = await _context.NPCs.FindAsync(npcIdLong);
                if (npc != null)
                {
                    npc.ImagePath = imagePath;
                    await _context.SaveChangesAsync();
                }
            }
        }
    }
}
