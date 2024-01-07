using System.ComponentModel.DataAnnotations;

namespace ProductAPI.Entities
{
    public class Product
    {   [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public int CategoryId { get; set; }
      
        public Category Category { get; set; }
    }
}
