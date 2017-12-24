﻿namespace Rapid.Data.Model {

    using Rapid.Data.Model.Security;
    using Rapid.Data.Model.Masters;

    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;


    public class ApplicationDbContext : IdentityDbContext<ApplicationUser> {

        public DbSet<DocumentType> DocumentTypes { get; set; }

        //public DbSet<LogEvent> LogEvents { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base((DbContextOptions) options) {
        }

        protected override void OnModelCreating(ModelBuilder builder) {
            base.OnModelCreating(builder);
            Dispose();
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}