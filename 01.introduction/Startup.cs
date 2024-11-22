using _01.introduction.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;

namespace _01.introduction
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddTransient<CustomMiddleware1>();

            //services.AddSingleton<IProductRepository, ProductRepository>();
            //services.AddScoped<IProductRepository, ProductRepository>();

            //services.AddTransient<IProductRepository, ProductRepository>();
            //services.AddTransient<IProductRepository, TestRepository>();        // this will overwrite erlier registered service

            // if we use try version then it will only register the service it it was not registered erlier
            services.TryAddTransient<IProductRepository, ProductRepository>();
            services.TryAddTransient<IProductRepository, TestRepository>();  
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello from Use \n");
            //    await next();
            //    await context.Response.WriteAsync("Hello from Use 2 \n");
            //});

            //app.UseMiddleware<CustomMiddleware1>();

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello from Run \n");
            //});

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoint =>
            {
                endpoint.MapControllers();
            });
        }
    }
}
