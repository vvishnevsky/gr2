using hw.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace hw
{
    public class Program
    {
        public static Car car;

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();
            builder.Services.AddSingleton<IManagementCars, Car>();

            var app = builder.Build();

            app.MapControllers();

            car = new Car("volvo", "xc60", "FF", "dark blue", "wagon", "e", "diesel", "auto", DateTime.Parse("01.01.2020"));

            app.MapGet("/", () => "Hello, world!");

            app.Map("/GetName", GetName);
            app.Map("/GetEngine", GetEngine);
            app.Map("/GetAge", GetAge);
            app.Map("/get", GetCarMidleware);

            app.Run();
        }

        private static void GetName(IApplicationBuilder applicationBuilder)
        {
            applicationBuilder.Run(async context => {
                await context.Response.WriteAsync(await car.GetCarName());
            });
        }

        private static void GetEngine(IApplicationBuilder applicationBuilder)
        {
            applicationBuilder.Run(async context => {
                await context.Response.WriteAsync(await car.GetCarEngine());
            });
        }

        private static void GetAge(IApplicationBuilder applicationBuilder)
        {
            applicationBuilder.Run(async context => {
                await context.Response.WriteAsync(await car.GetCarAge());
            });
        }

        private static void GetCarMidleware(IApplicationBuilder applicationBuilder)
        {
            applicationBuilder.Run(async context => {
                await context.Response.WriteAsync(await GetCar(car));
            });
        }

        private async static Task<string> GetCar([FromServices] IManagementCars car)
        {
            return await car.GetCar();
        }
    }
}