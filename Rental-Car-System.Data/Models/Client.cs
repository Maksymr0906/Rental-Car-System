namespace Rental_Car_System.Data.Models
{
    public sealed class Client : Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirthday { get; set; }
        public double Balance { get; set; }
        public ICollection<BankCard> BankCards { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
