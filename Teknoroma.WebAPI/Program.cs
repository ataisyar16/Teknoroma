using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Teknoroma.Entities.DAL.Contexts;
using Teknoroma.Entities.Entities.Concrete;

namespace Teknoroma.WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // CORS ayarlar�
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAll", policyBuilder =>
                {
                    policyBuilder.AllowAnyOrigin()
                                 .AllowAnyHeader()
                                 .AllowAnyMethod();
                });
            });

            // Identity ve Entity Framework konfig�rasyonu
            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddIdentity<AppUser, IdentityRole>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 6;
            }).AddEntityFrameworkStores<AppDbContext>();

            // Controller servisini ekle
            builder.Services.AddControllers();

            // Swagger/OpenAPI deste�i
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Title = "Teknoroma API",
                    Version = "v1"
                });
            });

            var app = builder.Build();

            // Geli�tirme ortam�nda Swagger'� aktifle�tir
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Teknoroma API v1"));
            }

            // Statik dosyalar� aktif et
            app.UseStaticFiles();

            // CORS politikas� ekle
            app.UseCors("AllowAll");

            app.UseHttpsRedirection();

            // Yetkilendirme
            app.UseAuthentication();
            app.UseAuthorization();

            // Controller endpoint'lerini e�le
            app.MapControllers();

            // Uygulamay� �al��t�r
            app.Run();
        }
    }
}
