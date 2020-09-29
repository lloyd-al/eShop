using System;


namespace eShop.Catalog.Core.Entities
{
    public abstract class BaseEntity
    {
        public string CreatedBy { get; set; }
        public DateTime? Created { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModified { get; set; }
    }
}
