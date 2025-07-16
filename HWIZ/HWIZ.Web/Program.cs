using HWIZ.Data.Interfaces;
using HWIZ.Data.Models;
using HWIZ.Data.Repositories;
using HWIZ.Domain.Interfaces;
using HWIZ.Domain.Services;
using HWIZ.Web.Components;
using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;

namespace HWIZ.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();
            builder.Services.AddMudServices();
            builder.Services.AddDbContext<HWIZAPPContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("HWIZAPP")));

            builder.Services.AddScoped<IBaseRepository<Utilizadores>, BaseRepository<Utilizadores>>();
            builder.Services.AddScoped<IBaseRepository<Ferias>, BaseRepository<Ferias>>();
            builder.Services.AddScoped<IUtilizadoresService, UtilizadoresService>();
            builder.Services.AddScoped<IFeriasService, FeriasService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseAntiforgery();

            app.MapStaticAssets();
            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}
