namespace Rental_Car_System.Bussiness.Exceptions
{
	public class CardValidationException : Exception
	{
		public CardValidationException(string message) : base(message) { }
	}
}