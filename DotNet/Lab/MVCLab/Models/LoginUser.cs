using System.ComponentModel.DataAnnotations;

namespace MVCLab.Models;

public class LoginUser
{
    [Required(ErrorMessage = "Username cannot be empty !")]
    public string UserName { get; set; }
    [Required(ErrorMessage = "password cannot be empty !")]
    public string Password{ get; set; }
    
}