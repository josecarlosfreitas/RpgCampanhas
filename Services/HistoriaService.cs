using RpgCampanhas.Models;
using RpgCampanhas.Repositories.Interfaces;
using RpgCampanhas.Services.Interfaces;

namespace RpgCampanhas.Services
{
    public class HistoriaService : BaseService<Historia>, IHistoriaService
    {
        private readonly IHistoriaRepository _historiaRepository;

        public HistoriaService(IHistoriaRepository historiaRepository)
            : base(historiaRepository)
        {
            _historiaRepository = historiaRepository;
        }

        public Task<IEnumerable<Historia>> GetByCampanhaId(long campanhaId)
        {
            return _historiaRepository.GetByCampanhaId(campanhaId);
        }

    }
}
