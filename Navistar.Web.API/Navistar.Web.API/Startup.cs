using Navistar.Model.common;
using Navistar.Model.Factory;
using Navistar.Model.Request;
using Navistar.Model.Response;
using Navistar.Business.Orders;
using Navistar.Business.OrdersImp;
using Navistar.DAO.Orders;
using Navistar.DAO.OrdersImp;
using Navistar.DataContext;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Swagger;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Rewrite;
using Mastercon;
using Navistar.Utils.Logger;
using Microsoft.EntityFrameworkCore;
using System;
namespace Navistar.Web.API
{
    public class Startup
    {
        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();

        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<DBDataMartEntityFmwImp>(c =>
            {
                try
                {
                    c.UseSqlServer(Configuration.GetConnectionString("NavimexVentasDB"));
                  
                }
                catch (Exception exception)
                {
                    var message = exception.Message;
                }
            });



            services.Configure<ConnectionsConfig>(Configuration.GetSection("ConnectionStrings"));
            services.Configure<ConnectionsConfig>(Configuration.GetSection("MasterConnectConfig"));


            services.AddScoped<IOrderDAO<TCP001_PEDIDO>, OrderDAOImp>();
            services.AddScoped<IOrderEFDAO, OderEntityFmwkDAOImp>();
            services.AddScoped<IOrderBusiness<TCP001_PEDIDO>, OrderBusinessImp>();
            services.AddScoped<IOrderBusinessEF, OrderBusinessEFImp>();

            services.AddScoped<Masterconnect_Interface, Masterconnect>();
 
            ///Scope for database
            services.AddScoped<IDBContext<DBNavimexVentasImp>, DBNavimexVentasImp>();
            services.AddScoped<IDBContext<DBDatamartImp>, DBDatamartImp>();
 

            //Scope for Utils
            services.AddScoped<Navistar.Utils.Logger.ILogger, Logger>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "API Navistar ", Version = "v1" });
            });

            //TypeAdapterFactory.SetCurrent(new AutomapperTypeAdapterFactory());
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure (IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();
            app.UseAuthentication();
            app.UseMvcWithDefaultRoute();

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "API Navistar v1");
            });

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Catalog}/{action=Index}/{id?}");
            });
        }
    }
}
