using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eProdaja.Model.Requests;
using eProdaja.WebApi.Database;
using eProdaja.WebApi.Filters;
using eProdaja.WebApi.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;

namespace eProdaja.WebApi
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
            services.AddMvc(x=>x.Filters.Add<ErrorFilter>()).SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            // Register the Swagger generator, defining 1 or more Swagger documents


            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });
            });

            //services.AddScoped</*IProizvodService*/, ProizvodService>();
            services.AddScoped<IKorisniciService, KorisniciService>();
            services.AddScoped<IVrsteProizvodaService, VrsteProizvodaService>();
            services.AddScoped<IService<Model.JediniceMjere, object>, BaseService<Model.JediniceMjere, object, Database.JediniceMjere>>();

            services.AddScoped<ICRUDService<Model.Proizvod, ProizvodSearchRequest,ProizvodiUpSetRequest,ProizvodiUpSetRequest>,ProizvodService>();
            services.AddScoped<ICRUDService<Model.Skladista, SkladistaSearchRequest, SkladistaUpsertRequest, SkladistaUpsertRequest>, SkladistaService>();
            //services.AddScoped<IService<Model.VrsteProizvoda, object>, BaseService<Model.VrsteProizvoda, object, Database.VrsteProizvoda>>();
            services.AddAutoMapper(typeof(Startup)); ;

            var connection = @"Server=.;Database=eProdaja;Trusted_Connection=True;ConnectRetryCount=0";
            services.AddDbContext<eProdajaContext>(options => options.UseSqlServer(connection));

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

            app.UseHttpsRedirection();
            app.UseMvc();

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseMvc();


        }
    }
}
