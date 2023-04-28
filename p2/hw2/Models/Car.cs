namespace hw.Models
{
    public class Car : IManagementCars
    {
        public string? Manufacturer { get; set; }
        public string? Name { get; set; }
        public string? Layout { get; set; }
        public string? Colour { get; set; }
        public string? Body { get; set; }
        public string? Class { get; set; }
        public string? Engine { get; set; }
        public string? Transmission { get; set; }
        public DateTime? ProdDate { get; set; }

        public Car()
        {
            Name = "no car name";
        }

        public Car(string? manufacturer, string? name, string? layout, string? colour, string? body, string? @class, string? engine,
            string? transmission, DateTime? prodDate)
        {
            Manufacturer = manufacturer;
            Name = name;
            Layout = layout;
            Colour = colour;
            Body = body;
            Class = @class;
            Engine = engine;
            Transmission = transmission;
            ProdDate = prodDate;
        }

        public async Task<string> GetCarAge()
        {
            return "Car age is " + (DateTime.Now.Year - ProdDate.Value.Year).ToString();
        }

        public async Task<string> GetCarEngine()
        {
            return "Car engine is " + Engine;
        }

        public async Task<string> GetCarName()
        {
            return $"Car name is {Manufacturer} {Name}";
        }

        public async Task<string> GetCar()
        {
            return await GetCarName() + "\n" + await GetCarEngine() + "\n" + await GetCarAge();
        }
    }
}
