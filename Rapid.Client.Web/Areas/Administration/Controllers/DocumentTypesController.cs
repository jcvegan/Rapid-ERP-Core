namespace Rapid.Client.Web.Areas.Administration.Controllers {
    
    using CrossCutting.Service.Definition.Data;

    using Microsoft.AspNetCore.Mvc;

    public class DocumentTypesController : Controller {

        private readonly IDocumentTypeManagementService _documentTypeManagementService = null;

        public DocumentTypesController(IDocumentTypeManagementService documentTypeManagementService) {
            _documentTypeManagementService = documentTypeManagementService;
        }

        [Area("Administration")]
        public ViewResult Index() {
            return View();
        }
    }
}