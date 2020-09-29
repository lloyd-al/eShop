using System;
using eShop.Common.Core.Interfaces;


namespace eShop.Common.Infrastructure.Services
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}
