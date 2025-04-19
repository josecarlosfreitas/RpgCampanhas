using RpgCampanhas.Models;
using RpgCampanhas.Repositories.Interfaces;
using RpgCampanhas.Services.Interfaces;

namespace RpgCampanhas.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public Task<Usuario> GetUsuarioById(long id)
        {
            return _usuarioRepository.GetUsuarioById(id);
        }

        public Task<IEnumerable<Usuario>> GetAll()
        {
            return _usuarioRepository.GetAll();
        }

        public Task<Usuario> Add(Usuario usuario)
        {
            return _usuarioRepository.Add(usuario);
        }

        public Task<Usuario> Update(Usuario usuario)
        {
            return _usuarioRepository.Update(usuario);
        }

        public Task Delete(long id)
        {
            return _usuarioRepository.Delete(id);
        }

        public Task<IEnumerable<Usuario>> GetMestres()
        {
            return _usuarioRepository.GetMestres();
        }

        public Task<IEnumerable<Usuario>> GetJogadores()
        {
            return _usuarioRepository.GetJogadores();
        }

        public Task<Usuario> Login(string email, string senha)
        {
            return _usuarioRepository.Login(email, senha);
        }
    }
}
