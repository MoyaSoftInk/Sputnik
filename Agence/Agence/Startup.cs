using Agence.Domain.Entities;
using Agence.Domain.Entities.Repositories;
using Agence.Domain.Mapper;
using Agence.Domain.Repositories;
using Agence.Domain.Services;
using Agence.Domain.Services.imp;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace Agence
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));

            #region DB Connection

            var sqlConnectionString = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<AgenceDBContext>(options =>
                options.UseLazyLoadingProxies().UseSqlServer(
                    sqlConnectionString,
                    b => b.MigrationsAssembly(">Agence.Domain")
                )
            );

            #endregion

            #region Repositories

            services.AddTransient<ICaoUsuarioRepository, CaoUsuarioRepository>();
            services.AddTransient<IPermissaoSistemaRepository, PermissaoSistemaRepository>();
            services.AddTransient<ICaoFaturaRepository, CaoFaturaRepository>();
            services.AddTransient<ICaoOsRepository, CaoOsRepository>();
            services.AddTransient<ICaoSalarioRepository, CaoSalarioRepository>();

            #endregion

            #region Services

            services.AddTransient<ICaoUsuarioService, CaoUsuarioService>();
            services.AddTransient<IPermissaoSistemaService, PermissaoSistemaService>();
            services.AddTransient<IConsultorService, ConsultorService>();
            services.AddTransient<ICaoFaturaService, CaoFaturaService>();
            services.AddTransient<ICaoOsService, CaoOsService>();
            services.AddTransient<ICaoSalarioService, CaoSalarioService>();

            #endregion

            #region AutoMapper Configure

            ConfigureAutoMapper.Now();

            #endregion

            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "Agence", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            app.UseCors("MyPolicy");

            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Agence RestAPI");
            });

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
