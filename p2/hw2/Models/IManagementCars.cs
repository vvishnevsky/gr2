namespace hw.Models
{
    public interface IManagementCars
    {
        Task<string> GetCarName();
        Task<string> GetCarEngine();
        Task<string> GetCarAge();
        Task<string> GetCar();
    }
}
