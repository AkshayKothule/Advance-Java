using System.ComponentModel.DataAnnotations;

namespace EndModule.Model
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="name is requird ")]
        public string Name { get; set; }
        [Required(ErrorMessage ="description requird ")]
        public string Description { get; set; }
        [Required(ErrorMessage ="price is requird")]
        
        public int Price { get; set; }
        [Required(ErrorMessage ="qty is requird ")]
        [Range(10 , 50 , ErrorMessage ="Enter in range 10 to 50")]
        public int Qty { get; set; }

        public bool Available { get; set; }
    }
}
