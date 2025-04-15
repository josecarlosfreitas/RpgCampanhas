using RpgCampanhas.Models;
using RpgCampanhas.Repositories.Interfaces;
using RpgCampanhas.Services.Interfaces;

namespace RpgCampanhas.Services
{
    public class Ficha3detService : BaseService<Ficha3det>, IFicha3detService
    {
        private readonly IFicha3detRepository _ficha3detRepository;

        public Ficha3detService(IFicha3detRepository ficha3detRepository)
            : base(ficha3detRepository)
        {
            _ficha3detRepository = ficha3detRepository;
        }

        public Task<IEnumerable<Ficha3det>> GetByPersonagemId(long personagemId)
        {
            return _ficha3detRepository.GetByPersonagemId(personagemId);
        }

        public Task<IEnumerable<Ficha3det>> GetByNpcId(long npcId)
        {
            return _ficha3detRepository.GetByNpcId(npcId);
        }

    }
}
