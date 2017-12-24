// Jcvegan.com - Juan Carlos Vega Neira
// Rapid.Data.Repository 2017
// IRepository.cs
// Todos los derechos reservados

using System.Threading.Tasks;

namespace Rapid.Data.Repository.Definition {
    using System;
    using System.Collections.Generic;

    public interface IRepository<TEntity> :IDisposable where TEntity : class {

        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        void Delete(TEntity entity);
        void DeleteRange(IEnumerable<TEntity> entities);
        void Update(TEntity entity);
        void UpdateRange(IEnumerable<TEntity> entities);
        
        IEnumerable<TEntity> ListAll();
        Task<IEnumerable<TEntity>> ListAllAsync();
    }
}