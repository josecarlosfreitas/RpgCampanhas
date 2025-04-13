using Microsoft.AspNetCore.Mvc;
using RpgCampanhas.DTO;
using RpgCampanhas.Models;
using RpgCampanhas.Services.Interfaces;

namespace RpgCampanhas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CampanhaController : ControllerBase
    {
        private readonly ICampanhaService _campanhaService;

        public CampanhaController(ICampanhaService campanhaService)
        {
            _campanhaService = campanhaService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CampanhaDTO>>> GetCampanhas()
        {
            var campanhas = await _campanhaService.GetAll();
            var campanhasDto = campanhas.Select(u => new CampanhaDTO
            {
                Id = u.Id,
                Nome = u.Nome,
                Descricao = u.Descricao,
                MestreId = u.MestreId,
            });
            return Ok(campanhasDto);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CampanhaDTO>> GetCampanha(int id)
        {
            var campanha = await _campanhaService.GetById(id);
            if (campanha == null)
            {
                return NotFound();
            }
            var campanhaDto = new CampanhaDTO
            {
                Id = campanha.Id,
                Nome = campanha.Nome,
                Descricao = campanha.Descricao,
                MestreId = campanha.MestreId
            };
            return Ok(campanhaDto);
        }

        [HttpPost]
        public async Task<ActionResult<Campanha>> PostCampanha(CampanhaDTO campanhaDTO)
        {
            var campanha = new Campanha
            {
                Nome = campanhaDTO.Nome,
                Descricao = campanhaDTO.Descricao,
                MestreId = campanhaDTO.MestreId,
            };
            await _campanhaService.Add(campanha);
            return CreatedAtAction(nameof(GetCampanha), new { id = campanha.Id }, campanha);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCampanha(int id, CampanhaDTO campanhaDTO)
        {
            var campanha = await _campanhaService.GetById(id);
            if (campanha == null)
            {
                return NotFound();
            }

            campanha.Nome = campanhaDTO.Nome;
            campanha.Descricao = campanhaDTO.Descricao;
            campanha.MestreId = campanhaDTO.MestreId;

            await _campanhaService.Update(campanha);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCampanha(int id)
        {
            var campanha = await _campanhaService.GetById(id);
            if (campanha == null)
            {
                return NotFound();
            }

            await _campanhaService.Delete(id);
            return NoContent();
        }

        [HttpGet("mestre/{mestreId}")]
        public async Task<ActionResult<CampanhaDTO>> GetCampanhaByMestreId(long mestreId)
        {
            var campanhas = await _campanhaService.GetByMestreId(mestreId);
            
            var campanhasDto = campanhas.Select(c => new CampanhaDTO
            {
                Id = c.Id,
                Nome = c.Nome,
                Descricao = c.Descricao,
                MestreId = c.MestreId
            });
            
            return Ok(campanhasDto);
        }

    }
}
