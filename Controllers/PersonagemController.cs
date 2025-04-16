using Microsoft.AspNetCore.Mvc;
using RpgCampanhas.DTO;
using RpgCampanhas.Models;
using RpgCampanhas.Services.Interfaces;

namespace RpgCampanhas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonagemController : ControllerBase
    {
        private readonly IPersonagemService _personagemService;

        public PersonagemController(IPersonagemService personagemService)
        {
            _personagemService = personagemService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PersonagemDTO>>> GetPersonagens()
        {
            var personagens = await _personagemService.GetAll();
            var personagensDto = personagens.Select(u => new PersonagemDTO
            {
                Id = u.Id,
                Nome = u.Nome,
                CampanhaId = u.CampanhaId,
                JogadorId = u.JogadorId,
                ImagePath = u.ImagePath
            });
            return Ok(personagensDto);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PersonagemDTO>> GetPersonagem(int id)
        {
            var personagem = await _personagemService.GetById(id);
            if (personagem == null)
            {
                return NotFound();
            }
            var personagemDto = new PersonagemDTO
            {
                Id = personagem.Id,
                Nome = personagem.Nome,
                CampanhaId = personagem.CampanhaId,
                JogadorId = personagem.JogadorId,
                ImagePath = personagem.ImagePath
            };
            return Ok(personagemDto);
        }

        [HttpPost]
        public async Task<ActionResult<Personagem>> PostPersonagem(PersonagemDTO personagemDTO)
        {
            var personagem = new Personagem
            {
                Nome = personagemDTO.Nome,
                JogadorId = personagemDTO.JogadorId,
                CampanhaId = personagemDTO.CampanhaId,
                TipoFicha = "",
                ImagePath = ""
            };
            await _personagemService.Add(personagem);
            return CreatedAtAction(nameof(GetPersonagem), new { id = personagem.Id }, personagem);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPersonagem(int id, PersonagemDTO personagemDTO)
        {
            var personagem = await _personagemService.GetById(id);
            if (personagem == null)
            {
                return NotFound();
            }

            personagem.Nome = personagemDTO.Nome;
            personagem.JogadorId = personagemDTO.JogadorId;

            await _personagemService.Update(personagem);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePersonagem(int id)
        {
            var personagem = await _personagemService.GetById(id);
            if (personagem == null)
            {
                return NotFound();
            }

            await _personagemService.Delete(id);
            return NoContent();
        }

        [HttpGet("campanha/{campanhaId}")]
        public async Task<ActionResult<PersonagemDTO>> GetPersonagemByCampanhaId(long campanhaId)
        {
            var personagens = await _personagemService.GetByCampanhaId(campanhaId);
            
            var personagensDto = personagens.Select(c => new PersonagemDTO
            {
                Id = c.Id,
                Nome = c.Nome,
                CampanhaId = c.CampanhaId,
                JogadorId = c.JogadorId,
                JogadorNome = c.Jogador.Nome,
                ImagePath = c.ImagePath
            });
            
            return Ok(personagensDto);
        }

    }
}
