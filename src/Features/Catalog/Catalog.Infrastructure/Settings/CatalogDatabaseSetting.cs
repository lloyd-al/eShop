using System;
using eShop.Catalog.Core.Interfaces;


namespace eShop.Catalog.Infrastructure.Settings
{
    public class CatalogDatabaseSetting : ICatalogDatabaseSetting
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string CollectionName { get; set; }
    }
}
