using System;


namespace eShop.Ordering.Core.Interfaces
{
    public interface IBaseEntity<TId>
    {
        TId Id { get; }
    }
}
