using System;


namespace eShop.Catalog.Application.DTOs
{
    public class ProductDto
    {
        public string Id { get; set; }
        public string ProductName { get; set; }
        public string ProductCategory { get; set; }
        public string ProductSummary { get; set; }
        public string ProductDescription { get; set; }
        public string ProductImageFile { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
