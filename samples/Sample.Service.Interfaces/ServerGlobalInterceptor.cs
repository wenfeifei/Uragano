﻿using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Uragano.Abstractions;
using Uragano.DynamicProxy.Interceptor;
using Uragano.Remoting;

namespace Sample.Service.Interfaces
{
    public class ServerGlobalInterceptor : InterceptorAbstract
    {
        private ILogger Logger { get; }

        public ServerGlobalInterceptor(ILogger<ServerGlobalInterceptor> logger)
        {
            Logger = logger;
        }
        public override async Task<ResultMessage> Intercept(IInterceptorContext context)
        {
            Logger.LogDebug("\n---------------->Server global interceptor\n");
            return await context.Next();
        }
    }
}
