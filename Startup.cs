using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ECHO_API.Domain.Repositories;
using ECHO_API.Domain.Repositories.AdmisionRepository;
using ECHO_API.Domain.Repositories.InternamientosRepository;
using ECHO_API.Domain.Repositories.PacientesRepository;
using ECHO_API.Domain.Services.AdmisionService;
using ECHO_API.Domain.Services.InternamientosService;
using ECHO_API.Domain.Services.PacientesService;
using ECHO_API.Persistence.Context;
using ECHO_API.Persistence.Repositories;
using ECHO_API.Persistence.Repositories.AdmisionRepository;
using ECHO_API.Persistence.Repositories.InternamientosRepository;
using ECHO_API.Persistence.Repositories.PacientesRepository;
using ECHO_API.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace ECHO_API
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            var ConnectionString = Configuration.GetConnectionString("BdConnection"); // getting the string connection from appsettings 
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(ConnectionString).EnableSensitiveDataLogging(true)
            );

            // Space for services and repos

            services.AddScoped<IPacienteRepository, PacientesRepository>();
            services.AddScoped<IPacientesService, PacientesService>();

            services.AddScoped<IInternamientosRepository, InternamientosRepository>();
            services.AddScoped<IInternamientosService, InternamientosService>();

            services.AddScoped<IAdmisionRepository, AdmisionRepository>();
            services.AddScoped<IAdmisionService, AdmisionService>();
            
            services.AddAutoMapper(typeof(Startup).Assembly);
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = ContextCacheKey => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;

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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
