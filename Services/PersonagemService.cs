using RpgCampanhas.Models;
using RpgCampanhas.Repositories.Interfaces;
using RpgCampanhas.Services.Interfaces;

namespace RpgCampanhas.Services
{
    public class PersonagemService : BaseService<Personagem>, IPersonagemService
    {
        private readonly IPersonagemRepository _personagemRepository;

        public PersonagemService(IPersonagemRepository personagemRepository)
            : base(personagemRepository)
        {
            _personagemRepository = personagemRepository;
        }

        
        public Task<IEnumerable<Personagem>> GetByCampanhaId(long campanhaId)
        {
            return _personagemRepository.GetByCampanhaId(campanhaId);
        }
    }
}
