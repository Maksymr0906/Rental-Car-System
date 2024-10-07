namespace Rental_Car_System.Data.Models
{
	public class BankCard : Entity
	{
		public string CardNumber { get; set; }
		public string CVV { get; set; }
		public DateOnly ExpirationDate { get; set; }
		public Guid ClientId { get; set; }
		public Client Client { get; set; }
	}
}
