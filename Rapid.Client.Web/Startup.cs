using Rapid.Client.Web.Settings;

namespace Rapid.Client.Web {

    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Services;
    using CrossCutting.Service.Definition;
    using CrossCutting.Service.Definition.Data;
    using CrossCutting.Service.Implementation;
    using CrossCutting.Service.Implementation.Data;
    using Data.Model;
    using Data.Model.Security;

    public class Startup {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            // Add application services.
            services.AddTransient<IEmailSender, EmailSender>();
            var appSettings = Configuration.GetSection("AppSettings");
            services.Configure<RapidAppSettings>(appSettings);
            services.AddTransient<ILoggingService, LoggingService>((ctx) => {
                var dbContext = new ApplicationDbContext(new DbContextOptions<ApplicationDbContext>() { });
                return new LoggingService(dbContext);
            });
            //services.Add(new ServiceDescriptor(typeof(IDocumentTypeManagementService),typeof(DocumentTypeManagementService),ServiceLifetime.Scoped));
            services.AddTransient<IDocumentTypeManagementService, DocumentTypeManagementService>((ctx) => {
                var dbContext = new ApplicationDbContext(new DbContextOptions<ApplicationDbContext>() { });
                return new DocumentTypeManagementService(dbContext, ctx.GetService<ILoggingService>());
            });
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
                app.UseDatabaseErrorPage();
            }
            else {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseAuthentication();
            //ConfigurationBuilder builder = new ConfigurationBuilder();
            //builder.SetBasePath(env.ContentRootPath);
            //builder.AddJsonFile("appsettings.json");
            //builder.Build();
            app.UseMvc(routes => {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
                routes.MapRoute(
                    name: "areas",
                    template: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
    }
}