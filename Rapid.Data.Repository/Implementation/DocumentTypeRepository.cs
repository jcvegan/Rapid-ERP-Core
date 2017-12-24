// Jcvegan.com - Juan Carlos Vega Neira
// Rapid.Data.Repository 2017
// DocumentTypeRepository.cs
// Todos los derechos reservados
namespace Rapid.Data.Repository.Implementation {

    using Definition;

    using Microsoft.EntityFrameworkCore;
    using Model.Masters;

    using System.Linq;
    using System.Threading.Tasks;

    public class DocumentTypeRepository : Repository<DocumentType>, IDocumentTypeRepository {
        public DocumentTypeRepository(DbContext context) : base(context) {
        }

        public DocumentType GetDocumentDocumentTypeById(long documentTypeId) {
            return Context.Set<DocumentType>().FirstOrDefault(x => x.Id == documentTypeId);
        }

        public async Task<DocumentType> GetDocumentDocumentTypeByIdAsync(long documentTypeId) {
            return await Context.Set<DocumentType>().FirstOrDefaultAsync(x => x.Id == documentTypeId);
        }
    }
}