using System.ComponentModel.DataAnnotations;

namespace DotNetTraining.Lesson9.AspApplication.ViewModels
{
    public class CreateUserViewModel
    {
        [Display(Name = "First Name:")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name:")]
        public string LastName { get; set; }
    }
}
