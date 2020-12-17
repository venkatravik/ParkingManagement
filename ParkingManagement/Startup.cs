using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ParkingManagement.Infrastracture.Interfaces;
using ParkingManagement.Infrastracture.Respository;
using ParkingManagement.Interfaces;
using ParkingManagement.Services;

namespace ParkingManagement
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
            services.AddControllers();
            services.AddTransient<IParkingRepository,ParkingRepository>();
            services.AddTransient<IParkingService, ParkingService>();
            services.AddTransient<ICarRepository, CarReposiroy>();
            services.AddTransient<ICarService, CarService>();
           // services.AddSingleton<DbContext, ParkingManegmentContext>();
            services.AddDbContext<ParkingManegmentContext>(e=>e.UseSqlServer("Data Source=.;Initial Catalog=ParkingManegment;Integrated Security=True;").EnableSensitiveDataLogging());


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
