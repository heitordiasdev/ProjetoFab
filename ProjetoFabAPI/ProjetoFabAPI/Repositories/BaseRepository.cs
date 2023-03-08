using Microsoft.EntityFrameworkCore;
using ProjetoFabAPI.Models.Data.Contexto;
using System.Xml.Linq;

namespace ProjetoFabAPI.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly DataContexto _dataContexto;

        public BaseRepository(DataContexto dataContexto)
        {
            _dataContexto = dataContexto;
        }
        public async Task Delete(string name)
        {
            var entity = await GetByName(name);
            _dataContexto.Set<T>().Remove(entity);
            await _dataContexto.SaveChangesAsync();
        }

        public Task Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dataContexto.Set<T>().AsNoTracking().ToListAsync();
        }

        public Task<T> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetByName(string name)
        {
            return await _dataContexto.Set<T>().FindAsync(name);
        }

        public async Task Insert(T entity)
        {
            await _dataContexto.Set<T>().AddAsync(entity);
             await _dataContexto.SaveChangesAsync();

        }

        public async Task Update(string name, T entity)
        {
            _dataContexto.Set<T>().Update(entity);
            await _dataContexto.SaveChangesAsync();
        }

        public Task Update(int Id, T entity)
        {
            throw new NotImplementedException();
        }
    }
}
