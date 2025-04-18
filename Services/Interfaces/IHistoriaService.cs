using RpgCampanhas.Models;

namespace RpgCampanhas.Services.Interfaces
{
    public interface IHistoriaService : IBaseService<Historia>
    {
        Task<IEnumerable<Historia>> GetByCampanhaId(long campanhaId);
    }
}
