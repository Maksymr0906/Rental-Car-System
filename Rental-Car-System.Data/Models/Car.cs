namespace Rental_Car_System.Data.Models
{
    public sealed class Car : Entity
    {
        public string Model { get; set; }
        public string Country { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public int YearOfManufacture { get; set; }
        public double FuelConsumption { get; set; }
        public double Price { get; set; }
        public bool IsDamaged { get; set; }
        public bool IsAvailable { get; set; }
        public string ImgPath { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
