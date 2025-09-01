using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Model
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public string ProductName {  get; set; }

        public int Price { get; set; }
    }
}
