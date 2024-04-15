namespace NestShop.Models
{
    public class Vendor
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<Product>? Products { get; set; }
    }
}
