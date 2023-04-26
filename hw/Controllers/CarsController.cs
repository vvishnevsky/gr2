using hw.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace hw.Controllers
{
    [Route("/cars/get")]
    public class CarsController : ControllerBase
    {
        [HttpGet]
        public List<CarModel> Get()
        {
            List<CarModel> Cars = new()
            {
                new CarModel
                {
                    Manufacturer = "Audi", Name = "A2", Layout = "FF", Body = "", Class = "B", Transmission = "A", Colour = "grey",
                    Engine = "petrol"
                },

                new CarModel { Manufacturer = "Bmw", Layout = "FR", Class = "E", Name = "5", Body = "sedan", Engine = "petrol" }
            };

            return Cars;
        }
    }
}
