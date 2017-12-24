namespace Rapid.Data.Model.Masters {
    using Definition;

    using System;
    using System.ComponentModel.DataAnnotations;

    public class DocumentType  : IAuditableModel {
        [Key]
        public long Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedUser { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string LastUpdatedUser { get; set; }
    }
}