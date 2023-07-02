using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WelcomeUser.Models
{
    public class UserResponse
    {
        [Required(ErrorMessage = "Please Enter your name")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Please Enter your Mail ID")]
        [EmailAddress]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Please Enter your College Name")]
        public String? CollegeName { get; set; }
        [Required(ErrorMessage = "Please Enter your Mobile no")]
        public String? Phone { get; set; }
        [Required(ErrorMessage = "Please Specify are you an Adult")]
        public bool? IsAdult { get; set; }
    }
}
