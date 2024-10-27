namespace Rental_Car_System.Bussiness.Exceptions
{
    public class CarValidationException : Exception
    {
        public List<string> Errors { get; }
        public CarValidationException(IEnumerable<string> errors) : base("One or more validation errors occurred.") 
        {
            Errors = errors.ToList();
        }
    }
}
