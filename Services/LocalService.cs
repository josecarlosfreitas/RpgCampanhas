using RpgCampanhas.Models;
using RpgCampanhas.Repositories.Interfaces;
using RpgCampanhas.Services.Interfaces;

namespace RpgCampanhas.Services
{
    public class LocalService : BaseService<Local>, ILocalService
    {
        private readonly ILocalRepository _localRepository;

        public LocalService(ILocalRepository localRepository)
            : base(localRepository)
        {
            _localRepository = localRepository;
        }

        public Task<IEnumerable<Local>> GetByCampanhaId(long campanhaId)
        {
            return _localRepository.GetByCampanhaId(campanhaId);
        }

    }
}
