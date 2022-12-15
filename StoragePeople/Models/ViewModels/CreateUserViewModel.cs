using System.ComponentModel.DataAnnotations;

namespace StoragePeople.Models.ViewModels
{
    public class CreateUserViewModel
    {
        [Required]
        [Display(Name = "First Name")]
        [StringLength(120, MinimumLength = 2)]
        public string? FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(120, MinimumLength = 2)]
        public string? LastName { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [Display(Name = "User Name")]
        [StringLength(60, MinimumLength = 4)]
        public string? UserName { get; set; }

        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [StringLength(80, MinimumLength = 6)]
        public string? Password { get; set; }

        [Required]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string? ConfirmPassword { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }



    }
}
