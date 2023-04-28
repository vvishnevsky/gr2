namespace hw1.Models
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

        public Car()
        {
            Name = "car name";
        }

        public string GetCarAge()
        {
            throw new NotImplementedException();
        }

        public string GetCarEngine()
        {
            throw new NotImplementedException();
        }

        public string GetCarName()
        {
            return Name;
        }
    }
}