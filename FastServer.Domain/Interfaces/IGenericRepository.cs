//FastServer.Domain/Interfaces/IGenericRepository.cs
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FastServer.Domain.Interfaces;

public interface IGenericRepository<T> where T : class
{
    Task<T> GetByIdSync(int id);
    Task<IEnumerable<T>> GetAllAsync();
    Task AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(int id);
}
