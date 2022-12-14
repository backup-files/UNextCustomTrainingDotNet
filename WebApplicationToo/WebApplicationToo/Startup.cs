using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
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
using GraphQL;
using GraphQL.Server;
using WebApplicationToo.Data;
using WebApplicationToo.Data.GraphQL;
using WebApplicationToo.Repositories;

namespace WebApplicationToo
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
            services.AddDbContext<CollegeDbContext>(options => options.UseSqlServer(Configuration["ConnectionStrings:College"]));
            services.AddScoped<StudentRepository>();

            services.AddScoped<IServiceProvider>(s => new FuncServiceProvider(s.GetRequiredService));
            services.AddScoped<CollegeSchema>();
            services.AddGraphQL().AddSystemTextJson().AddGraphTypes(ServiceLifetime.Scoped);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, CollegeDbContext context)
        {
//            if (env.IsDevelopment())
//            {
//                app.UseDeveloperExceptionPage();
//            }

//            app.UseHttpsRedirection();
//            app.UseRouting();
//            app.UseAuthorization();
//            app.UseEndpoints(endpoints =>
//            {
//                endpoints.MapControllers();
//            });

            app.UseGraphQL<CollegeSchema>();
            app.UseGraphQLPlayground();


            context.Seed();
        }
    }
}
