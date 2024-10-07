namespace Rental_Car_System.Data.Exceptions
{
	public class CardValidationException : Exception
	{
		public CardValidationException(string message) : base(message) { }
	}
}