using System.ComponentModel.DataAnnotations;

namespace DotNetTraining.Lesson9.AspApplication.ViewModels
{
    public class CreateUserViewModel
    {
        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        [Display(Name = "First Name:")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        [Display(Name = "Last Name:")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Password:")]
        public string Password { get; set; }

        [Compare(nameof(Password), ErrorMessage = "Passwords do not meet")]
        [Display(Name = "Confirm password:")]
        public string ConfirmPassword { get; set; }
    }
}
