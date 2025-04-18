using Microsoft.AspNetCore.Mvc;
using RpgCampanhas.DTO;
using RpgCampanhas.Models;
using RpgCampanhas.Services.Interfaces;

namespace RpgCampanhas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HistoriaController : ControllerBase
    {
        private readonly IHistoriaService _historiaService;

        public HistoriaController(IHistoriaService historiaService)
        {
            _historiaService = historiaService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<HistoriaDTO>>> GetHistorias()
        {
            var historias = await _historiaService.GetAll();
            var historiasDto = historias.Select(u => new HistoriaDTO
            {
                CampanhaId = u.CampanhaId,
                Id = u.Id,
                Conteudo = u.Conteudo,
                Titulo = u.Titulo,
            });
            return Ok(historiasDto);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<HistoriaDTO>> GetHistoria(int id)
        {
            var historia = await _historiaService.GetById(id);
            if (historia == null)
            {
                return NotFound();
            }
            var historiaDto = new HistoriaDTO
            {
                Id = historia.Id,
                Titulo = historia.Titulo,
                Conteudo = historia.Conteudo,
                CampanhaId = historia.CampanhaId,
            };
            return Ok(historiaDto);
        }

        [HttpPost]
        public async Task<ActionResult<Historia>> PostHistoria(HistoriaDTO historiaDTO)
        {
            var historia = new Historia
            {
                CampanhaId = historiaDTO.CampanhaId,
                Titulo = historiaDTO.Titulo,
                Conteudo = historiaDTO.Conteudo,
                DataCriacao = DateTime.Now,
            };
            await _historiaService.Add(historia);
            return CreatedAtAction(nameof(GetHistoria), new { id = historia.Id }, historia);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutHistoria(int id, HistoriaCriarDTO historiaDTO)
        {
            var historia = await _historiaService.GetById(id);
            if (historia == null)
            {
                return NotFound();
            }

            historia.Titulo = historiaDTO.Titulo;
            historia.Conteudo = historiaDTO.Conteudo;

            await _historiaService.Update(historia);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHistoria(int id)
        {
            var historia = await _historiaService.GetById(id);
            if (historia == null)
            {
                return NotFound();
            }

            await _historiaService.Delete(id);
            return NoContent();
        }

        [HttpGet("campanha/{campanhaId}")]
        public async Task<ActionResult<HistoriaDTO>> GetHistoriaByCampanhaId(long campanhaId)
        {
            var historias = await _historiaService.GetByCampanhaId(campanhaId);
            
            var historiasDto = historias.Select(c => new HistoriaDTO
            {
                Id = c.Id,
                Titulo = c.Titulo,
                Conteudo = c.Conteudo,
                CampanhaId = c.CampanhaId,
            });
            
            return Ok(historiasDto);
        }

    }
}
