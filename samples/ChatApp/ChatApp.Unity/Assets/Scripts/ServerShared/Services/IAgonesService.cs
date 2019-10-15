﻿using ChatApp.Shared.MessagePackObjects;
using MagicOnion;
using MessagePack;

namespace ChatApp.Shared.Services
{
    /// <summary>
    /// Client -> Server API
    /// </summary>
    public interface IAgonesService : IService<IAgonesService>
    {
        UnaryResult<bool> Allocate();
        UnaryResult<AgonesGameServerResponse> GetGameServer();
    }
}
