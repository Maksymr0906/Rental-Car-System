namespace Rental_Car_System.Data.Exceptions
{
    public class MissingClientDataException : Exception
    {
        public MissingClientDataException() : base("Fill in your personal data in profile before ordering.")
        {
            
        }
    }
}
