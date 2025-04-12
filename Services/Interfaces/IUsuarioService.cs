using RpgCampanhas.Models;

namespace RpgCampanhas.Services.Interfaces
{
    public interface IUsuarioService
    {
        Task<Usuario> GetUsuarioById(long id);
        Task<IEnumerable<Usuario>> GetAll();
        Task<Usuario> Add(Usuario usuario);
        Task<Usuario> Update(Usuario usuario);
        Task Delete(long id);
    }
}
