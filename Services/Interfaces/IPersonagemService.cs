using RpgCampanhas.Models;

namespace RpgCampanhas.Services.Interfaces
{
    public interface IPersonagemService : IBaseService<Personagem>
    {
        Task<IEnumerable<Personagem>> GetByCampanhaId(long campanhaId);
        Task<IEnumerable<Personagem>> GetByJogadorId(long jogadorId);
        Task<IEnumerable<Personagem>> GetByCampanhaIdEJogadorId(long campanhaId, long jogadorId);
    }
}
