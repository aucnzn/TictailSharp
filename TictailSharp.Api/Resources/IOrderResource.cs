﻿using TictailSharp.Api.Methods;
using TictailSharp.Api.Model.Order;

namespace TictailSharp.Api.Resources
{
    /// <summary>
    /// Order repository interface
    /// </summary>
    public interface IOrderResource : IGetRange<Order>, IGetSpecific<Order>, IStore
    {
    }
}
