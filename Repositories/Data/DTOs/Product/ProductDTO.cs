using Repositories.Data.Entity;
using Repositories.Enums;

namespace Repositories.Data.DTOs.Product
{
    public class ProductDTO
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public string SubCategoryId { get; set; }
    }
}
