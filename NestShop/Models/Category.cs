using System.ComponentModel.DataAnnotations.Schema;

namespace NestShop.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Icon { get; set; } = null!;
        [NotMapped]
        public IFormFile File { get; set; } 
        public List<Product>? Products { get; set; }
        public bool SoftDeleted { get; set; }
    }
}
