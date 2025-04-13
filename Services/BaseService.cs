using RpgCampanhas.Repositories.Interfaces;
using RpgCampanhas.Services.Interfaces;

namespace RpgCampanhas.Services
{
    public class BaseService<T> : IBaseService<T> where T : class
    {
        protected readonly IBaseRepository<T> _repository;

        public BaseService(IBaseRepository<T> repository)
        {
            _repository = repository;
        }

        public virtual async Task<T> GetById(long id)
        {
            return await _repository.GetById(id);
        }

        public virtual async Task<IEnumerable<T>> GetAll()
        {
            return await _repository.GetAll();
        }

        public virtual async Task<T> Add(T entity)
        {
            return await _repository.Add(entity);
        }

        public virtual async Task<T> Update(T entity)
        {
            return await _repository.Update(entity);
        }

        public virtual async Task Delete(long id)
        {
            await _repository.Delete(id);
        }
    }
}
