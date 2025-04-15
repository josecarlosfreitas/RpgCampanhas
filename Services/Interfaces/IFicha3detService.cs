using RpgCampanhas.Models;

namespace RpgCampanhas.Services.Interfaces
{
    public interface IFicha3detService : IBaseService<Ficha3det>
    {
        Task<IEnumerable<Ficha3det>> GetByPersonagemId(long personagemId);
        Task<IEnumerable<Ficha3det>> GetByNpcId(long npcId);
    }
}
