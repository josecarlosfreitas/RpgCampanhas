namespace RpgCampanhas.Services.Interfaces
{
    public interface IBaseService<T> where T : class
    {
        Task<T> GetById(long id);
        Task<IEnumerable<T>> GetAll();
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task Delete(long id);
    }
}
