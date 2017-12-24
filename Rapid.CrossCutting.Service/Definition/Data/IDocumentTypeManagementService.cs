// Jcvegan.com - Juan Carlos Vega Neira
// Rapid.CrossCutting.Service 2017
// IDocumentTypeManagementService.cs
// Todos los derechos reservados
namespace Rapid.CrossCutting.Service.Definition.Data {
    using Rapid.Data.Model.Masters;

    public interface IDocumentTypeManagementService {
        void CreateDocumentType(DocumentType documentType);
        void UpdateDocumentType(DocumentType documentType);
        void DeleteDocumentType(long documentTypeId);
    }
}