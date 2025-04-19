using Microsoft.AspNetCore.Mvc;
using RpgCampanhas.DTO;
using RpgCampanhas.Models;
using RpgCampanhas.Services.Interfaces;

namespace RpgCampanhas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UsuarioDTO>>> GetUsuarios()
        {
            var usuarios = await _usuarioService.GetAll();
            var usuariosDto = usuarios.Select(u => new UsuarioDTO
            {
                Id = u.Id,
                Nome = u.Nome,
                Email = u.Email,
                Senha = u.Senha,
                Tipo = u.Tipo
            });
            return Ok(usuariosDto);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UsuarioDTO>> GetUsuario(int id)
        {
            var usuario = await _usuarioService.GetUsuarioById(id);
            if (usuario == null)
            {
                return NotFound();
            }
            var usuarioDto = new UsuarioDTO
            {
                Id = usuario.Id,
                Nome = usuario.Nome,
                Email = usuario.Email,
                Senha = usuario.Senha,
                Tipo = usuario.Tipo
            };
            return Ok(usuarioDto);
        }

        [HttpPost]
        public async Task<ActionResult<Usuario>> PostUsuario(UsuarioDTO usuarioDTO)
        {
            var usuario = new Usuario
            {
                Nome = usuarioDTO.Nome,
                Email = usuarioDTO.Email,
                Senha = usuarioDTO.Senha,
                Tipo = usuarioDTO.Tipo
            };
            await _usuarioService.Add(usuario);
            return CreatedAtAction(nameof(GetUsuario), new { id = usuario.Id }, usuario);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsuario(int id, UsuarioDTO usuarioDTO)
        {
            var usuario = await _usuarioService.GetUsuarioById(id);
            if (usuario == null)
            {
                return NotFound();
            }

            usuario.Nome = usuarioDTO.Nome;
            usuario.Email = usuarioDTO.Email;
            usuario.Senha = usuarioDTO.Senha;
            usuario.Tipo = usuarioDTO.Tipo;

            await _usuarioService.Update(usuario);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsuario(int id)
        {
            var usuario = await _usuarioService.GetUsuarioById(id);
            if (usuario == null)
            {
                return NotFound();
            }

            await _usuarioService.Delete(id);
            return NoContent();
        }

        [HttpGet("mestres")]
        public async Task<ActionResult<IEnumerable<UsuarioDTO>>> GetMestres()
        {
            var mestres = await _usuarioService.GetMestres();
            var mestresDto = mestres.Select(u => new UsuarioDTO
            {
                Id = u.Id,
                Nome = u.Nome,
                Email = u.Email,
                Senha = u.Senha,
                Tipo = u.Tipo
            });
            return Ok(mestresDto);
        }

        [HttpGet("jogadores")]
        public async Task<ActionResult<IEnumerable<UsuarioDTO>>> GetJogadores()
        {
            var jogadores = await _usuarioService.GetJogadores();
            var jogadoresDto = jogadores.Select(u => new UsuarioDTO
            {
                Id = u.Id,
                Nome = u.Nome,
                Email = u.Email,
                Senha = u.Senha,
                Tipo = u.Tipo
            });
            return Ok(jogadoresDto);
        }

        [HttpGet("login")]
        public async Task<ActionResult<UsuarioDTO>> Login(string email, string senha)
        {
            var usuario = await _usuarioService.Login(email, senha);
            if (usuario == null)
            {
                return NotFound();
            }
            var usuarioDto = new UsuarioDTO
            {
                Id = usuario.Id,
                Nome = usuario.Nome,
                Email = usuario.Email,
                Senha = usuario.Senha,
                Tipo = usuario.Tipo
            };
            return Ok(usuarioDto);
        }
    }
}
