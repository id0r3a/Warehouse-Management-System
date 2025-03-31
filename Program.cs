
using Microsoft.EntityFrameworkCore;
using Warehouse_Management_System.Mappers;
using Warehouse_Management_System.Models;

namespace Warehouse_Management_System
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<WarehouseManagementSystemContext>(options => options.UseSqlServer("Server=Dorsa\\SQLEXPRESS;Database=WarehouseManagementSystem;Trusted_Connection=True;TrustServerCertificate=True;"));
            
            // Lägg till AutoMapper i services
            builder.Services.AddAutoMapper(typeof(MappingProfile));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
