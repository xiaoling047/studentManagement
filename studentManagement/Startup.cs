using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using studentManagement.models;

namespace studentManagement
{
    public class Startup
    {
        private readonly IConfiguration config;
        public Startup(IConfiguration configureServicesFilter)
        {
            config = configureServicesFilter;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppContextDb>(options => {
                options.UseSqlServer(config.GetConnectionString("DefaultConnection"));
            });
            services.AddMvc(options => { options.EnableEndpointRouting = false; });
            services.AddSingleton<StudentRepository, StudentMock>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                Console.WriteLine("development");
                app.UseDeveloperExceptionPage();
            }
            /*DefaultFilesOptions defaultFilesOptions = new DefaultFilesOptions();
            defaultFilesOptions.DefaultFileNames.Clear();*/
            // defaultFilesOptions.DefaultFileNames.Add("test.html");

            // app.UseDefaultFiles(defaultFilesOptions);
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
            //app.UseRouting();
      
            

           /* app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                   
                    await context.Response.WriteAsync(env.EnvironmentName);
                });
            });*/
        }
    }
}
