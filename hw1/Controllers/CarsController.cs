using Microsoft.AspNetCore.Mvc;

namespace hw1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarsController : ControllerBase
    {
        private readonly ILogger<CarsController> _logger;

        public CarsController(ILogger<CarsController> logger)
        {
            _logger = logger;
        }

        public List<Model> Cars = new List<Model>();

        [HttpGet(Name = "GetWeatherForecast")]
        public List<Model> Get()
        {
            Cars.Add(new Model
            {
                Manufacturer = "Audi",
                Name = "A2",
                Layout = "FF",
                Body = "",
                Class = "B",
                Transmission = "A",
                Colour = "grey",
                Engine = "petrol"
            });
            Cars.Add(new Model { Manufacturer = "Bmw", Layout = "FR", Class = "E", Name = "5", Body = "sedan", Engine = "petrol" });
            return Cars;
        }
    }
}