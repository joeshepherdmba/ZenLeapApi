using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore;
using Microsoft.Extensions.Logging;
using ZenLeapApi.Data;

namespace ZenLeapApi
{
    public class Startup
    {
        //https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/routing
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            //services.AddDbContext<DataContext>(opt => opt.in.UseInMemoryDatabase());
            services.AddMvc();
			//services.AddDbContextPool<DataContext>(
			//  options => options.UseSqlServer(connectionString)
			//);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseMvc();
            DataContext context = new DataContext();
            DbInitializer.Initialize(context);

			//app.UseMvc(routes =>
			//{
			//	routes.MapRoute(name: "default",
			//					template: "api/{controller=Default}/{action=Get}/{id?}");
			//});

			//app.UseMvc(routes =>
			//{
			//	routes.MapRoute(
			//		name: "default",
			//		template: "{controller=Account}/{action=Index}");

			//});
            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
            //});

			//app.UseMvc(routes =>
			//{
			//	routes.MapRoute("blog", "blog/{*article}",
			//			 defaults: new { controller = "Blog", action = "Article" });
			//	routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
			//}
        }
    }
}
