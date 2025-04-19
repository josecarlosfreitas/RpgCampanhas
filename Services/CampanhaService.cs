using RpgCampanhas.Models;
using RpgCampanhas.Repositories.Interfaces;
using RpgCampanhas.Services.Interfaces;

namespace RpgCampanhas.Services
{
    public class CampanhaService : ICampanhaService
    {
        private readonly ICampanhaRepository _campanhaRepository;

        public CampanhaService(ICampanhaRepository campanhaRepository)
        {
            _campanhaRepository = campanhaRepository;
        }

        public Task<Campanha> GetById(long id)
        {
            return _campanhaRepository.GetById(id);
        }

        public Task<IEnumerable<Campanha>> GetAll()
        {
            return _campanhaRepository.GetAll();
        }

        public Task<Campanha> Add(Campanha model)
        {
            return _campanhaRepository.Add(model);
        }

        public Task<Campanha> Update(Campanha model)
        {
            return _campanhaRepository.Update(model);
        }

        public Task Delete(long id)
        {
            return _campanhaRepository.Delete(id);
        }

        public Task<IEnumerable<Campanha>> GetByMestreId(long mestreId)
        {
            return _campanhaRepository.GetByMestreId(mestreId);
        }

        public Task<IEnumerable<Campanha>> GetByUsuario(long usuarioId)
        {
            return _campanhaRepository.GetByUsuario(usuarioId);
        }
    }
}
