using System.ComponentModel.DataAnnotations;

namespace ProductAPI.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set; } 
        [Required]
        public string Title { get; set; } 
        
        public string Description { get; set; }

    }
}
