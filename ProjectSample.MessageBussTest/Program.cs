﻿using ProjectSample.CommandsAndEvents;
using RedisUsage.CqrsCore.Ddd;
using RedisUsage.CqrsCore.RegisterEngine;
using RedisUsage.RedisServices;
using System;

namespace ProjectSample.MessageBussTest
{
    class Program
    {
        static void Main(string[] args)
        {
            RedisServices.Init("127.0.0.1", null, string.Empty);

            CommandsAndEventsRegisterEngine.AutoRegisterForHandlers();

            Guid sampleId = Guid.NewGuid();

            CommandPublisher.Instance.Send(new CreateSample(sampleId, "Version.1.0","{}"));

            CommandPublisher.Instance.Send(new ChangeVersionOfSample(sampleId, "Version.2.0"));

        }
    }
}
