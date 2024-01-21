using Microsoft.EntityFrameworkCore;
using StoreApp.Models;

namespace StoreApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<RepositoryContext>(options =>
            {
                options.UseSqlite(builder.Configuration.GetConnectionString("sqlConnection"));
            });

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            app.UseStaticFiles();

            app.UseHttpsRedirection();
            app.UseRouting();

            app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
