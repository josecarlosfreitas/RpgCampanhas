using Microsoft.AspNetCore.Mvc;
using RpgCampanhas.DTO;
using RpgCampanhas.Models;
using RpgCampanhas.Services.Interfaces;

namespace RpgCampanhas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Ficha3detController : ControllerBase
    {
        private readonly IFicha3detService _ficha3detService;

        public Ficha3detController(IFicha3detService ficha3detService)
        {
            _ficha3detService = ficha3detService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ficha3detDTO>>> GetPersonagens()
        {
            var ficha3dets = await _ficha3detService.GetAll();
            var ficha3detsDto = ficha3dets.Select(ficha3det => new Ficha3detDTO
            {
                Id = ficha3det.Id,
                Nome = ficha3det.Nome,
                NpcId = ficha3det.NpcId,
                PersonagemId = ficha3det.PersonagemId,
                Armadura = ficha3det.Armadura,
                DinheiroEItens = ficha3det.DinheiroEItens,
                Desvantagens = ficha3det.Desvantagens,
                Historia = ficha3det.Historia,
                Habilidade = ficha3det.Habilidade,
                MagiasConhecidas = ficha3det.MagiasConhecidas,
                Notas = ficha3det.Notas,
                PoderDeFogo = ficha3det.PoderDeFogo,
                Pontos = ficha3det.Pontos,
                PontosDeExperiencia = ficha3det.PontosDeExperiencia,
                PontosDeMagia = ficha3det.PontosDeMagia,
                Forca = ficha3det.Forca,
                Resistencia = ficha3det.Resistencia,
                TiposDeDano = ficha3det.TiposDeDano,
                Vantagens = ficha3det.Vantagens,
                PontosDeVida = ficha3det.PontosDeVida,
            });
            return Ok(ficha3detsDto);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Ficha3detDTO>> GetFicha3det(int id)
        {
            var ficha3det = await _ficha3detService.GetById(id);
            if (ficha3det == null)
            {
                return NotFound();
            }
            var ficha3detDto = new Ficha3detDTO
            {
                Id = ficha3det.Id,
                Nome = ficha3det.Nome,
                NpcId = ficha3det.NpcId,
                PersonagemId = ficha3det.PersonagemId,
                Armadura = ficha3det.Armadura,
                DinheiroEItens = ficha3det.DinheiroEItens,
                Desvantagens = ficha3det.Desvantagens,
                Historia = ficha3det.Historia,
                Habilidade = ficha3det.Habilidade,
                MagiasConhecidas = ficha3det.MagiasConhecidas,
                Notas = ficha3det.Notas,
                PoderDeFogo = ficha3det.PoderDeFogo,
                Pontos = ficha3det.Pontos,
                PontosDeExperiencia = ficha3det.PontosDeExperiencia,
                PontosDeMagia = ficha3det.PontosDeMagia,
                Forca = ficha3det.Forca,
                Resistencia = ficha3det.Resistencia,
                TiposDeDano = ficha3det.TiposDeDano,
                Vantagens = ficha3det.Vantagens,
                PontosDeVida = ficha3det.PontosDeVida,
            };
            return Ok(ficha3detDto);
        }

        [HttpPost]
        public async Task<ActionResult<Ficha3det>> PostFicha3det(Ficha3detDTO ficha3detDTO)
        {
            var ficha3det = new Ficha3det
            {
                Nome = ficha3detDTO.Nome,
                NpcId = ficha3detDTO.NpcId,
                PersonagemId = ficha3detDTO.PersonagemId,
                Armadura = ficha3detDTO.Armadura,
                DinheiroEItens = ficha3detDTO.DinheiroEItens,
                Desvantagens = ficha3detDTO.Desvantagens,
                Historia = ficha3detDTO.Historia,
                Habilidade = ficha3detDTO.Habilidade,
                MagiasConhecidas = ficha3detDTO.MagiasConhecidas,
                Notas = ficha3detDTO.Notas,
                PoderDeFogo = ficha3detDTO.PoderDeFogo,
                Pontos = ficha3detDTO.Pontos,
                PontosDeExperiencia = ficha3detDTO.PontosDeExperiencia,
                PontosDeMagia = ficha3detDTO.PontosDeMagia,
                Forca = ficha3detDTO.Forca,
                Resistencia = ficha3detDTO.Resistencia,
                TiposDeDano = ficha3detDTO.TiposDeDano,
                Vantagens = ficha3detDTO.Vantagens,
                PontosDeVida = ficha3detDTO.PontosDeVida,
            };
            await _ficha3detService.Add(ficha3det);
            return CreatedAtAction(nameof(GetFicha3det), new { id = ficha3det.Id }, ficha3det);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutFicha3det(int id, Ficha3detDTO ficha3detDTO)
        {
            var ficha3det = await _ficha3detService.GetById(id);
            if (ficha3det == null)
            {
                return NotFound();
            }

            ficha3det.Nome = ficha3detDTO.Nome;
            ficha3det.NpcId = ficha3detDTO.NpcId;
            ficha3det.PersonagemId = ficha3detDTO.PersonagemId;
            ficha3det.Armadura = ficha3detDTO.Armadura;
            ficha3det.DinheiroEItens = ficha3detDTO.DinheiroEItens;
            ficha3det.Desvantagens = ficha3detDTO.Desvantagens;
            ficha3det.Historia = ficha3detDTO.Historia;
            ficha3det.Habilidade = ficha3detDTO.Habilidade;
            ficha3det.MagiasConhecidas = ficha3detDTO.MagiasConhecidas;
            ficha3det.Notas = ficha3detDTO.Notas;
            ficha3det.Resistencia = ficha3detDTO.Resistencia;
            ficha3det.Forca = ficha3detDTO.Forca;
            ficha3det.PoderDeFogo = ficha3detDTO.PoderDeFogo;
            ficha3det.Pontos = ficha3detDTO.Pontos;
            ficha3det.PontosDeExperiencia = ficha3detDTO.PontosDeExperiencia;
            ficha3det.PontosDeMagia = ficha3detDTO.PontosDeMagia;
            ficha3det.TiposDeDano = ficha3detDTO.TiposDeDano;
            ficha3det.Vantagens = ficha3detDTO.Vantagens;
            ficha3det.PontosDeVida = ficha3detDTO.PontosDeVida;

            await _ficha3detService.Update(ficha3det);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFicha3det(int id)
        {
            var ficha3det = await _ficha3detService.GetById(id);
            if (ficha3det == null)
            {
                return NotFound();
            }

            await _ficha3detService.Delete(id);
            return NoContent();
        }

        [HttpGet("personagem/{personagemId}")]
        public async Task<ActionResult<Ficha3detDTO>> GetByPersonagemId(long personagemId)
        {
            var ficha3dets = await _ficha3detService.GetByPersonagemId(personagemId);
            
            var ficha3detsDto = ficha3dets.Select(ficha3det => new Ficha3detDTO
            {
                Id = ficha3det.Id,
                Nome = ficha3det.Nome,
                NpcId = ficha3det.NpcId,
                PersonagemId = ficha3det.PersonagemId,
                Armadura = ficha3det.Armadura,
                DinheiroEItens = ficha3det.DinheiroEItens,
                Desvantagens = ficha3det.Desvantagens,
                Historia = ficha3det.Historia,
                Habilidade = ficha3det.Habilidade,
                MagiasConhecidas = ficha3det.MagiasConhecidas,
                Notas = ficha3det.Notas,
                PoderDeFogo = ficha3det.PoderDeFogo,
                Pontos = ficha3det.Pontos,
                PontosDeExperiencia = ficha3det.PontosDeExperiencia,
                PontosDeMagia = ficha3det.PontosDeMagia,
                Forca = ficha3det.Forca,
                Resistencia = ficha3det.Resistencia,
                TiposDeDano = ficha3det.TiposDeDano,
                Vantagens = ficha3det.Vantagens,
                PontosDeVida = ficha3det.PontosDeVida,
            });
            
            return Ok(ficha3detsDto);
        }

        [HttpGet("npc/{npcId}")]
        public async Task<ActionResult<Ficha3detDTO>> GetByNpcId(long npcId)
        {
            var ficha3dets = await _ficha3detService.GetByNpcId(npcId);

            var ficha3detsDto = ficha3dets.Select(ficha3det => new Ficha3detDTO
            {
                Id = ficha3det.Id,
                Nome = ficha3det.Nome,
                NpcId = ficha3det.NpcId,
                PersonagemId = ficha3det.PersonagemId,
                Armadura = ficha3det.Armadura,
                DinheiroEItens = ficha3det.DinheiroEItens,
                Desvantagens = ficha3det.Desvantagens,
                Historia = ficha3det.Historia,
                Habilidade = ficha3det.Habilidade,
                MagiasConhecidas = ficha3det.MagiasConhecidas,
                Notas = ficha3det.Notas,
                PoderDeFogo = ficha3det.PoderDeFogo,
                Pontos = ficha3det.Pontos,
                PontosDeExperiencia = ficha3det.PontosDeExperiencia,
                PontosDeMagia = ficha3det.PontosDeMagia,
                Forca = ficha3det.Forca,
                Resistencia = ficha3det.Resistencia,
                TiposDeDano = ficha3det.TiposDeDano,
                Vantagens = ficha3det.Vantagens,
                PontosDeVida = ficha3det.PontosDeVida,
            });

            return Ok(ficha3detsDto);
        }

        }
}
