using System;
using Play.Common;

namespace Play.Inventory.Services.Entities
{
    public partial class CatalogItem : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
    }
}