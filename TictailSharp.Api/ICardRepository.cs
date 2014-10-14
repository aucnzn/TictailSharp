﻿using TictailSharp.Api.Methods;
using TictailSharp.Api.Model;

namespace TictailSharp.Api
{
    public interface ICardRepository : IStore, IPost<Card, string>
    {
    }
}
