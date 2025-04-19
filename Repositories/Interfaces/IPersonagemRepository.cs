using RpgCampanhas.Models;

namespace RpgCampanhas.Repositories.Interfaces
{
    public interface IPersonagemRepository : IBaseRepository<Personagem>
    {
        Task<IEnumerable<Personagem>> GetByCampanhaId(long campanhaId);
        Task<IEnumerable<Personagem>> GetByJogadorId(long jogadorId);
    }
}
