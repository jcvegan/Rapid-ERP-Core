// Jcvegan.com - Juan Carlos Vega Neira
// Rapid.Data.Repository 2017
// IDocumentTypeRepository.cs
// Todos los derechos reservados

using System.Threading.Tasks;

namespace Rapid.Data.Repository.Definition {
    using Model.Masters;
    public interface IDocumentTypeRepository : IRepository<DocumentType> {
        DocumentType GetDocumentDocumentTypeById(long documentTypeId);
        Task<DocumentType> GetDocumentDocumentTypeByIdAsync(long documentTypeId);
    }
}