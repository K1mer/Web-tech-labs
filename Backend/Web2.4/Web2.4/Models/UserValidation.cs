using System.ComponentModel.DataAnnotations;

namespace Web2._4.Models
{
    public class UserValidation
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public string Remember { get; set; }

        public string BirthDay_Day { get; set; }
        public string BirthDay_Month { get; set; }
        public string BirthDay_Year { get; set; }
    }
}
