namespace hw.Models
{
    public class CarModel : IManagementCars
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

        public CarModel()
        {
            Name = "no car name";
        }

        public CarModel(string? manufacturer, string? name, string? layout, string? colour, string? body, string? @class, string? engine, string? transmission)
        {
            Manufacturer = manufacturer;
            Name = name;
            Layout = layout;
            Colour = colour;
            Body = body;
            Class = @class;
            Engine = engine;
            Transmission = transmission;
        }

        public int GetCarAge()
        {
            return DateTime.Now.Year - ProdDate.Value.Year;
        }

        public string GetCarEngine()
        {
            return Engine;
        }

        public string GetCarName()
        {
            return Name;
        }
    }
}
