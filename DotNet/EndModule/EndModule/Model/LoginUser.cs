using System.ComponentModel.DataAnnotations;

namespace EndModule.Model;

public class LoginUser
{
    [Required(ErrorMessage = "Username is required")]
    public string Name { get; set; }
    [Required(ErrorMessage = "Password is required")]
    public string Password { get; set; }
}