namespace Rental_Car_System.Data.Models
{
    public sealed class Admin : Person
    {
        public enum AdminRole
        {
            SuperAdmin,
            Moderator,
            Support
        };
        public string Email { get; set; }
        public AdminRole Role { get; set; }
    }
}
