using RpgCampanhas.Models;

namespace RpgCampanhas.Repositories.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<Usuario> GetUsuarioById(long id);
        Task<IEnumerable<Usuario>> GetAll();
        Task<Usuario> Add(Usuario usuario);
        Task<Usuario> Update(Usuario usuario);
        Task Delete(long id);
        Task<IEnumerable<Usuario>> GetMestres();
        Task<IEnumerable<Usuario>> GetJogadores();
        Task<Usuario> Login(string email, string senha);
    }
}
