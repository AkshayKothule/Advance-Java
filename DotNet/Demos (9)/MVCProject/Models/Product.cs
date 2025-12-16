using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MVCProject.Models;


[Table("Products")]
public class Product
{
    
    [Column("ProductID" , TypeName = "int")]
    [Key]
    public int pid { get; set; }
    [Column("ProductName" , TypeName = "varchar")]
    public string pname{ get; set; }
    [Column("type" , TypeName = "varchar")]
    public string type { get; set; }
    [Column("price" , TypeName = "int")] 
    public int price{ get; set; }

}

public class ProductContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    
    //connection 

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost,1433;Initial Catalog=IACSDDB;User Id=sa;Password=Akshay123#;TrustServerCertificate=True");
    }
}