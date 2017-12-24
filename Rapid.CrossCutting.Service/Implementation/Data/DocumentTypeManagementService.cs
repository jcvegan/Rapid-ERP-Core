// Jcvegan.com - Juan Carlos Vega Neira
// Rapid.CrossCutting.Service 2017
// DocumentTypeManagementService.cs
// Todos los derechos reservados
namespace Rapid.CrossCutting.Service.Implementation.Data {
    using Rapid.Data;
    using Rapid.Data.Model;
    using Rapid.Data.Model.Masters;
    using Definition.Data;
    using Definition;

    public sealed class DocumentTypeManagementService : IDocumentTypeManagementService {

        private readonly IUnitOfWork _unitOfWork;

        #region Services

        private readonly ILoggingService _loggingService = null;

        #endregion

        public DocumentTypeManagementService(ApplicationDbContext context, ILoggingService loggingService) {
            _loggingService = loggingService;
            _unitOfWork = new UnitOfWork(context);
        }

        public void CreateDocumentType(DocumentType documentType) {
            
        }

        public void UpdateDocumentType(DocumentType documentType) {
        }

        public void DeleteDocumentType(long documentTypeId) {
        }
    }
}