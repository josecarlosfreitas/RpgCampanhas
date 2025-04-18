using Microsoft.AspNetCore.Mvc;
using RpgCampanhas.DTO;
using RpgCampanhas.Models;
using RpgCampanhas.Services.Interfaces;

namespace RpgCampanhas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NpcController : ControllerBase
    {
        private readonly INpcService _npcService;

        public NpcController(INpcService npcService)
        {
            _npcService = npcService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<NpcDTO>>> GetNpcs()
        {
            var npcs = await _npcService.GetAll();
            var npcsDto = npcs.Select(u => new NpcDTO
            {
                Id = u.Id,
                Nome = u.Nome,
                CampanhaId = u.CampanhaId,
                ImagePath = u.ImagePath,
                Descricao = u.Descricao,
            });
            return Ok(npcsDto);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<NpcDTO>> GetNpc(int id)
        {
            var npc = await _npcService.GetById(id);
            if (npc == null)
            {
                return NotFound();
            }
            var npcDto = new NpcDTO
            {
                Id = npc.Id,
                Nome = npc.Nome,
                CampanhaId = npc.CampanhaId,
                ImagePath = npc.ImagePath,
                Descricao = npc.Descricao,
            };
            return Ok(npcDto);
        }

        [HttpPost]
        public async Task<ActionResult<NPC>> PostNpc(NpcDTO npcDTO)
        {
            var npc = new NPC
            {
                Nome = npcDTO.Nome,
                CampanhaId = npcDTO.CampanhaId,
                Descricao = npcDTO.Descricao,
                TipoFicha = "",
                ImagePath = "",
            };
            await _npcService.Add(npc);
            return CreatedAtAction(nameof(GetNpc), new { id = npc.Id }, npc);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutNpc(int id, NpcDTO npcDTO)
        {
            var npc = await _npcService.GetById(id);
            if (npc == null)
            {
                return NotFound();
            }

            npc.Nome = npcDTO.Nome;
            npc.Descricao = npcDTO.Descricao;

            await _npcService.Update(npc);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNpc(int id)
        {
            var npc = await _npcService.GetById(id);
            if (npc == null)
            {
                return NotFound();
            }

            await _npcService.Delete(id);
            return NoContent();
        }

        [HttpGet("campanha/{campanhaId}")]
        public async Task<ActionResult<NpcDTO>> GetNpcByCampanhaId(long campanhaId)
        {
            var npcs = await _npcService.GetByCampanhaId(campanhaId);
            
            var npcsDto = npcs.Select(c => new NpcDTO
            {
                Id = c.Id,
                Nome = c.Nome,
                CampanhaId = c.CampanhaId,
                ImagePath = c.ImagePath,
                Descricao = c.Descricao,
            });
            
            return Ok(npcsDto);
        }

    }
}
