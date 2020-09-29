using MongoDB.Driver;
using System.Collections.Generic;
using eShop.Catalog.Core.Entities;


namespace eShop.Catalog.Infrastructure.DataContexts
{
    public class CatalogDbContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetPreconfiguredProducts());
            }
        }

        private static IEnumerable<Product> GetPreconfiguredProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    ProductName = "IPhone X",
                    ProductSummary = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
                    ProductDescription = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                    ProductImageFile = "product-1.png",
                    ProductPrice = 950.00M,
                    ProductCategory = "Smart Phone"
                },
                new Product()
                {
                    ProductName = "Samsung 10",
                    ProductSummary = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
                    ProductDescription = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                    ProductImageFile = "product-2.png",
                    ProductPrice = 840.00M,
                    ProductCategory = "Smart Phone"
                },
                new Product()
                {
                    ProductName = "Huawei Plus",
                    ProductSummary = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
                    ProductDescription = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                    ProductImageFile = "product-3.png",
                    ProductPrice = 650.00M,
                    ProductCategory = "White Appliances"
                },
                new Product()
                {
                    ProductName = "Xiaomi Mi 9",
                    ProductSummary = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
                    ProductDescription = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                    ProductImageFile = "product-4.png",
                    ProductPrice = 470.00M,
                    ProductCategory = "White Appliances"
                },
                new Product()
                {
                    ProductName = "HTC U11+ Plus",
                    ProductSummary = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
                    ProductDescription = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                    ProductImageFile = "product-5.png",
                    ProductPrice = 380.00M,
                    ProductCategory = "Smart Phone"
                },
                new Product()
                {
                    ProductName = "LG G7 ThinQ",
                    ProductSummary = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
                    ProductDescription = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                    ProductImageFile = "product-6.png",
                    ProductPrice = 240.00M,
                    ProductCategory = "Home Kitchen"
                }
            };
        }
    }
}
