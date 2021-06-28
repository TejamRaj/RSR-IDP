using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RSR.IDP.DbContexts;
using RSR.IDP.Services;
using Microsoft.AspNetCore.Identity;

namespace RSR.IDP
{
    public class Startup
    {
        public IWebHostEnvironment Environment { get; }


        public IConfiguration Configuration { get; }
        public Startup(IWebHostEnvironment environment)
        {
            Environment = environment;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(opn=>
            opn.EnableEndpointRouting=false
            );


            services.AddScoped<IPasswordHasher<Entities.User>, PasswordHasher<Entities.User>>();
            services.AddScoped<ILocalUserService, LocalUserService>();
            services.AddDbContext<IdentityDbContext>(options =>
            {
                options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=RsRIdentityDB;Trusted_Connection=True;");
            });


            services.AddIdentityServer(isrvconfig =>
            {
                isrvconfig.Events.RaiseErrorEvents = true;
                isrvconfig.Events.RaiseInformationEvents = true;
                isrvconfig.Events.RaiseFailureEvents = true;
                isrvconfig.Events.RaiseSuccessEvents = true;
            }).AddDeveloperSigningCredential()
              .AddInMemoryIdentityResources(Config.GetIdentityResources())
              .AddInMemoryApiResources(Config.GetApiResources())
              .AddInMemoryApiScopes(Config.GetApiScopes())
              .AddInMemoryClients(Config.GetClients());
              
                
                
                
                

            services.AddCors();
        }

        public void Configure(IApplicationBuilder app,IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(c => c.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());

            app.UseIdentityServer();

            app.UseStaticFiles();
            app.UseRouting();

            app.UseMvcWithDefaultRoute();
           
        }
    }
}
