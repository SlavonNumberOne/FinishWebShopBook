using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using WebShop.BusinessLogic.Interface;
using WebShop.BusinessLogic.Servises;
using WebShop.BusinessLogic.Servises.Interface;
using WebShop.DataAccess1.Context;
using WebShop.DataAccess1.EFRepositories;
using WebShop.DataAccess1.Initialization;
using WebShop.DataAccess1.Interfaces;
using WebShop.DataAccess1;

namespace WebApp
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

            services.AddDbContext<ApplicationContext>(options =>
        options.UseSqlServer(
            Configuration.GetConnectionString("DefaultConnection")));
            //services.AddDbContext<ApplicationContext>(options =>
            //options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddMvc(option => option.EnableEndpointRouting = false);
            services.AddControllers();
            services.AddEntityFrameworkSqlServer()
                .AddDbContext<ApplicationContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"),

        x => x.MigrationsAssembly("WebApplication")));
            //options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<ApplicationContext>();
            services.AddTransient<IBookService, BookService>();
            // services.AddTransient<IAccountService, AccountService>();
            services.AddScoped<IAuthorService, AuthorService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<IAuthorRepository, AuthorRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IUserRepositive, UserRepository1>();
            services.AddScoped<ApplicationContext>();
            services.AddScoped<DataBaseInitialization>();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, DataBaseInitialization dataBase, ILoggerFactory loggerFactory)
        {

            app.UseAuthentication()
           .UseCors(opt => opt.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin())
           .UseMvc();

            dataBase.Initialize();

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
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                name: "default",
                template: "api/{controller}/{action}/{id?}");
            });
        }
    }
}
