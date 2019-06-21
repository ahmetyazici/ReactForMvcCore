


using Books.Business.Abstract;
using Books.Business.Concrete;
using Books.DataAccess.Abstract;
using Books.DataAccess.Concrete.NpgsqlFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Books.Services
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.AddScoped<IBookService, BookManager>();
            services.AddScoped<IBookDal, EfBookDal>();
            services.AddMvc();
            services.AddSession();
            services.AddDistributedMemoryCache();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseCors(bldr => bldr
           .WithOrigins("http://localhost:3000")
           .WithMethods("GET", "POST","DELETE","PUT")
           .AllowAnyHeader()
        );
            app.UseMvc();
            app.UseSession();
            app.UseMvcWithDefaultRoute();
        }
    }
}
