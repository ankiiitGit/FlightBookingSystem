using FlightBookingSystem.Configurations;
using FlightBookingSystem.Data;
using FlightBookingSystem.Repository;
using FlightBookingSystem.Repository.DBRepository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FlightBookingSystem
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
            services.AddCors();

            //services.AddControllers();
            services.AddControllers()
                .AddJsonOptions(options => 
                options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve);

            services.AddDbContext<FBSDbContext>();

            //services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<FMSDBContext>();

            //var Issuer = 

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "FlightBookingSystem", Version = "v1" });
            });

            // OAuth or JWT Authentication
            //services.AddAuthentication

            services.AddScoped<IUserRepository, DBUserRepository>();
            services.AddScoped<IAdminRepository, DBAdminRepository>();
            //services.AddScoped<IAirlineRepository, DBAirlineRepository>();
            //services.AddScoped<IFlightInfoRepository, DBFlightInfoRepository>();
            //services.AddScoped<IPassengerRepository, DBPassengerRepository>();
            //services.AddScoped<ITicketBookingRepository, DBTicketBookingRepository>();

            services.AddAutoMapper(typeof(AutoMapperConfig));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                //app.UseDeveloperExceptionPage();
                //app.UseSwagger();
                //app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "FlightBookingSystem v1"));
            }
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "FlightBookingSystem v1"));

            //app.UseHttpsRedirection();

            app.UseRouting();

            //app.UseAuthentication();

            app.UseCors(x => x
                .AllowAnyMethod()
                .AllowAnyHeader()
                .SetIsOriginAllowed(origin => true)
                .AllowCredentials());

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
