using Microsoft.AspNetCore.Routing.Constraints;
using MVC01.Middleware;

namespace MVC01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();
            app.UseMiddleware<RequestTimingMiddleware>();
            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

           
            app.UseHttpsRedirection();


            app.UseStaticFiles();

            app.UseRouting();

            //   app.UseCors();

            //  app.UseAuthentication();

            // app.UseSession();
            //inline middleware
            //app.Use(async (context, next) =>
            //     {
            //         //before next 
            //         Console.WriteLine($"Hello ");
            //         //next 
            //         await next(context);
            //         //After next 
            //         Console.WriteLine($"Bye");
            //     });

            app.UseAuthorization();

            app.MapStaticAssets();

            app.MapControllerRoute(
                name: "shop",
                pattern: "{controller}/{action}/{id}",
                defaults: new
                {
                    controller = "products",
                    action = "TestRouting"
                },
                constraints: new
                {
                    id= new IntRouteConstraint()
                }
                );
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id:int?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
