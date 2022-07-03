using API.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IIS_Exercise_10
{
    public class Startup
    {
        private List<Student> databasestudents;
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            databasestudents = new List<Student>
            {
                new Student{
                    Name = "Pero",
                    Surname ="Perić",
                    Grade = 1,
                    Subject = "Engleski"
                },
                new Student{
                    Name = "Ante",
                    Surname ="Perić",
                    Grade = 2,
                    Subject = "Njemački"
                },

            };
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddRazorPages();
            services.AddControllers().AddXmlDataContractSerializerFormatters();
            services.AddSingleton<List<Student>>(databasestudents);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
