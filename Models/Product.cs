using System.ComponentModel.DataAnnotations;

namespace mvc_web_azure_app_anand.Models
{
    public class Product
    {
        [Key]
        public int Id {  get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;  
        
        public decimal Price { get; set; }
    }
}
