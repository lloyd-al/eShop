using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Common.Core.Interfaces
{
    public interface IDateTimeService
    {
        DateTime NowUtc { get; }
    }
}
