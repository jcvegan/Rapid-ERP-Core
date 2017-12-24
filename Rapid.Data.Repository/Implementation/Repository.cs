// Jcvegan.com - Juan Carlos Vega Neira
// Rapid.Data.Repository 2017
// Repository.cs
// Todos los derechos reservados
namespace Rapid.Data.Repository.Implementation {
    using Definition;

    using Microsoft.EntityFrameworkCore;

    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class {

        private readonly DbContext _context;

        protected DbContext Context => _context;

        protected Repository(DbContext context) {
            this._context = context;
        }

        public void Dispose() {
            _context?.Dispose();
        }

        public void Add(TEntity entity) {
            _context.Set<TEntity>().Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities) {
            _context.Set<TEntity>().AddRange(entities);
        }

        public void Delete(TEntity entity) {
            _context.Set<TEntity>().Remove(entity);
        }

        public void DeleteRange(IEnumerable<TEntity> entities) {
            _context.Set<TEntity>().RemoveRange(entities);
        }

        public void Update(TEntity entity) {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void UpdateRange(IEnumerable<TEntity> entities) {
            foreach (TEntity entity in entities) {
                Update(entity);
            }
        }

        public IEnumerable<TEntity> ListAll() {
            return _context.Set<TEntity>().ToList();
        }

        public async Task<IEnumerable<TEntity>> ListAllAsync() {
            return await _context.Set<TEntity>().ToListAsync();
        }
    }
}