using RpgCampanhas.Models;

namespace RpgCampanhas.Services.Interfaces
{
    public interface ICampanhaService
    {
        Task<Campanha> GetById(long id);
        Task<IEnumerable<Campanha>> GetAll();
        Task<Campanha> Add(Campanha model);
        Task<Campanha> Update(Campanha model);
        Task Delete(long id);
        Task<IEnumerable<Campanha>> GetByMestreId(long mestreId);
    }
}
