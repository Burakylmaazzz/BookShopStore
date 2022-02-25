using BoohShop.Business.Services.Abstraction;
using BoohShop.Business.Services.Concrete;
using BookShop.DataAccess.Repositories.Repository.Abstraction;
using BookShop.DataAccess.Repositories.Repository.Concrete;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BookShop.UI
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
            services.AddMvc();

            //services.AddDbContext<ProjectContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<IBookRepository, EfBookRepository>();
            services.AddScoped<IBookService, BookManager>();

            services.AddScoped<IBookShopsRepository, EfBookShopsRepository>();
            services.AddScoped<IBookShopsService, BookShopsManager>();

            services.AddScoped<ICategoryRepository, EfCategoryRepository>();
            services.AddScoped<ICategoryService, CategoryManager>();

            services.AddScoped<ISubCategoryRepository, EfSubCategoryRepository>();
            services.AddScoped<ISubCategoryService, SubCategoryManager>();
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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }
}
