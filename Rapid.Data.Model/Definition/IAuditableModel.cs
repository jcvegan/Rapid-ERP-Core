// Jcvegan.com - Juan Carlos Vega Neira
// Rapid.Data.Model 2017
// IAuditableModel.cs
// Todos los derechos reservados
namespace Rapid.Data.Model.Definition {
    using System;

    public interface IAuditableModel {
        DateTime CreatedDate { get; set; }
        string CreatedUser { get; set; }
        DateTime LastUpdatedDate { get; set; }
        string LastUpdatedUser { get; set; }
    }
}