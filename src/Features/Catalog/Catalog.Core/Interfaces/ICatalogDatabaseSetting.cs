using System;


namespace eShop.Catalog.Core.Interfaces
{
    public interface ICatalogDatabaseSetting
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string CollectionName { get; set; }
    }
}
