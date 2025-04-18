using Microsoft.AspNetCore.Mvc;
using RpgCampanhas.DTO;
using RpgCampanhas.Models;
using RpgCampanhas.Services.Interfaces;

namespace RpgCampanhas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LocalController : ControllerBase
    {
        private readonly ILocalService _localService;

        public LocalController(ILocalService localService)
        {
            _localService = localService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<LocalDTO>>> GetLocals()
        {
            var locals = await _localService.GetAll();
            var localsDto = locals.Select(u => new LocalDTO
            {
                CampanhaId = u.CampanhaId,
                Id = u.Id,
                Nome = u.Nome,
                Descricao = u.Descricao,
                ImagePath = u.ImagePath,
            });
            return Ok(localsDto);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<LocalDTO>> GetLocal(int id)
        {
            var local = await _localService.GetById(id);
            if (local == null)
            {
                return NotFound();
            }
            var localDto = new LocalDTO
            {
                Id = local.Id,
                Nome = local.Nome,
                Descricao = local.Descricao,
                CampanhaId = local.CampanhaId,
                ImagePath = local.ImagePath,
            };
            return Ok(localDto);
        }

        [HttpPost]
        public async Task<ActionResult<Local>> PostLocal(LocalCriarDTO localDTO)
        {
            var local = new Local
            {
                CampanhaId = localDTO.CampanhaId,
                Descricao = localDTO.Descricao,
                Nome = localDTO.Nome,
                Mapa = "",
                ImagePath = "",
            };
            await _localService.Add(local);
            return CreatedAtAction(nameof(GetLocal), new { id = local.Id }, local);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutLocal(int id, LocalCriarDTO localDTO)
        {
            var local = await _localService.GetById(id);
            if (local == null)
            {
                return NotFound();
            }

            local.Nome = localDTO.Nome;
            local.Descricao = localDTO.Descricao;

            await _localService.Update(local);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLocal(int id)
        {
            var local = await _localService.GetById(id);
            if (local == null)
            {
                return NotFound();
            }

            await _localService.Delete(id);
            return NoContent();
        }

        [HttpGet("campanha/{campanhaId}")]
        public async Task<ActionResult<LocalDTO>> GetLocalByCampanhaId(long campanhaId)
        {
            var locals = await _localService.GetByCampanhaId(campanhaId);
            
            var localsDto = locals.Select(c => new LocalDTO
            {
                Id = c.Id,
                Nome = c.Nome,
                Descricao = c.Descricao,
                CampanhaId = c.CampanhaId,
                ImagePath = c.ImagePath,
            });
            
            return Ok(localsDto);
        }

    }
}
