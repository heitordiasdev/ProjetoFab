using Microsoft.EntityFrameworkCore;
using ProjetoFabAPI.Models.Data.Contexto;
using ProjetoFabAPI.Models.Domain.Entities;

namespace ProjetoFabAPI.Repositories
{
    public interface IBaseRepository<T> where T: class
    {
        Task Insert(T entity);
        Task Update(int Id,T entity);
        Task Delete(int Id);
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int Id);    
    }
}
