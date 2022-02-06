using JobPortalCore.DAL.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobPortalCore.DAL.Repository;
using JobPortalCore.BAL.services;
using JobPortalCore.BAL.Services;


namespace JobPortalCoreApi
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
            var connectionStr = Configuration.GetConnectionString("SqlConnection");
            services.AddDbContext<JobDbContext>(options => options.UseSqlServer(connectionStr));
            services.AddControllers();
            services.AddTransient<IJobDetailsRepository, JobDetailsRepository>();
            services.AddTransient<JobDetailsService, JobDetailsService>();
            services.AddTransient<ICandidateRegisterRepository, CandidateRegisterRepository>();
            services.AddTransient<CandidateRegisterService, CandidateRegisterService>();
            services.AddTransient<IEmployeeDetailsRepository, EmployeeDetailsRepository>();
            services.AddTransient<EmployeeDetailsService, EmployeeDetailsService>();
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