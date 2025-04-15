using RpgCampanhas.Models;

namespace RpgCampanhas.Repositories.Interfaces
{
    public interface IFicha3detRepository : IBaseRepository<Ficha3det>
    {
        Task<IEnumerable<Ficha3det>> GetByPersonagemId(long personagemId);
        Task<IEnumerable<Ficha3det>> GetByNpcId(long npcId);
    }
}
