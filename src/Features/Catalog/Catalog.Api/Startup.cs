using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using AutoMapper;
using eShop.Catalog.Api.Extensions;
using eShop.Catalog.Infrastructure;
using eShop.Catalog.Infrastructure.Settings;
using eShop.Catalog.Core.Interfaces;
using Microsoft.Extensions.Options;
using eShop.Catalog.Infrastructure.DataContexts;
using eShop.Catalog.Infrastructure.Repositories;
using eShop.Catalog.Application;

namespace Catalog.Api
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
            services.AddApplicationLayer();
            services.ConfigureApiVersioning();
            services.ConfigureSwagger();
            services.ConfigureLoggerService();
            services.ConfigureMailService();
            services.ConfigureDatabase(Configuration);

            services.AddControllers();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IApiVersionDescriptionProvider provider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseSwaggerExtension(provider);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
