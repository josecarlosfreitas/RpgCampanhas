using RpgCampanhas.Models;

namespace RpgCampanhas.Services.Interfaces
{
    public interface IPersonagemService : IBaseService<Personagem>
    {
        Task<IEnumerable<Personagem>> GetByCampanhaId(long campanhaId);
    }
}
