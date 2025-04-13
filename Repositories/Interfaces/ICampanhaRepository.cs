using RpgCampanhas.Models;

namespace RpgCampanhas.Repositories.Interfaces
{
    public interface ICampanhaRepository : IBaseRepository<Campanha>
    {
        Task<IEnumerable<Campanha>> GetByMestreId(long mestreId);
    }
}
