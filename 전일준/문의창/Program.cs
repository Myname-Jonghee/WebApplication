using Microsoft.EntityFrameworkCore;
using Ptoject_battery03.Data;

namespace Ptoject_battery03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            // Add DbContext for database connection
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();

            // 기본 경로를 InquiryController의 Create 액션으로 설정
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Inquiry}/{action=Create}/{id?}");

            app.Run();
        }
    }
}
