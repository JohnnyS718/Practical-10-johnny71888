using System.ComponentModel.DataAnnotations;
using SMS.Data.Entities;

namespace SMS.Web.Models;
    
public class UserViewModel
{       
    // TBC add attributes
    [Required]
    public string Name { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [StringLength(12, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
    public string Password { get; set; }

    [Compare(nameof(Password), ErrorMessage = "Passwords do not match")]
    public string PasswordConfirm { get; set; }

    [Required]
    public Role Role { get; set; }

}
