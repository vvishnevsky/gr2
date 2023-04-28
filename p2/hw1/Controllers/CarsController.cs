using hw1.Models;
using Microsoft.AspNetCore.Mvc;

namespace hw1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarsController : ControllerBase
    {
        [HttpGet(Name = "GetCars")]
        public List<Car> Get()
        {
            List<Car> Cars = new()
            {
                new Car
                {
                    Manufacturer = "Audi", Name = "A2", Layout = "FF", Body = "", Class = "B", Transmission = "A", Colour = "grey",
                    Engine = "petrol"
                },

                new Car { Manufacturer = "Bmw", Layout = "FR", Class = "E", Name = "5", Body = "sedan", Engine = "petrol" }
            };

            return Cars;
        }
    }
}