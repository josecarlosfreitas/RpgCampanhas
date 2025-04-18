using RpgCampanhas.Models;

namespace RpgCampanhas.Services.Interfaces
{
    public interface ILocalService : IBaseService<Local>
    {
        Task<IEnumerable<Local>> GetByCampanhaId(long campanhaId);
    }
}
