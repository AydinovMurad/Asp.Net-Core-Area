using NestShop.Models;

namespace NestShop.ViewModels
{
    public class ProductVm
    {
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
    }
}
