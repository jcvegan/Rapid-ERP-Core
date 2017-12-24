// Jcvegan.com - Juan Carlos Vega Neira
// Rapid.Data 2017
// IUnitOfWork.cs
// Todos los derechos reservados
namespace Rapid.Data {
    using Repository.Definition;

    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public interface IUnitOfWork : IDisposable {
        IDocumentTypeRepository DocumentTypes { get; }

        int Complete();
        Task<int> CompleteAsync(CancellationToken cancellationToken);

    }
}