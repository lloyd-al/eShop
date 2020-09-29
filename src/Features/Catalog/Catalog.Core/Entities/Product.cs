using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace eShop.Catalog.Core.Entities
{
    public class Product : BaseEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string ProductName { get; set; }
        public string ProductCategory { get; set; }
        public string ProductSummary { get; set; }
        public string ProductDescription { get; set; }
        public string ProductImageFile { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
