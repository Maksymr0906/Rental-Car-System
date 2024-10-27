namespace Rental_Car_System.Exceptions
{
	public class CardValidationException : Exception
	{
		public CardValidationException(string message) : base(message) { }
	}
}