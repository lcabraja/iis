using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using RestServis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestServis
{
    public class Startup
    {
        private List<Osoba> popisOsoba;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            popisOsoba = new List<Osoba>
            {
                new Osoba
                {
                    Ime = "Pero",
                    Prezime = "Periæ",
                    DatumRodenja = new DateTime(2000,5,6)
                },
                new Osoba
                {
                    Ime = "Iva",
                    Prezime = "Iviæ",
                    DatumRodenja = new DateTime(2010,10,15)
                }
            };
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers().AddXmlDataContractSerializerFormatters();

            services.AddSingleton<List<Osoba>>(popisOsoba);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
