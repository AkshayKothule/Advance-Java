using System.ComponentModel.DataAnnotations;

namespace Artitest.Models;

public class Artitest
{
    public int Aid { get; set; }
    [Required(ErrorMessage = "Name is required")]
    public  string Name { get; set; }
    [Required(ErrorMessage="Email is required")]
    public string  Email { get; set; }
   // [Required(ErrorMessage = "Contact is required")]
    public string Contact { get; set; }
    
    public string Skilldescription { get; set; }
}