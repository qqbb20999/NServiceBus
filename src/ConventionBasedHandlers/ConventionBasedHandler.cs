﻿using System;

namespace ConventionBasedHandlers
{
    using ConventionBasedMessages;
    using NServiceBus;

    public class ConventionBasedHandler : IHandleMessages<MyMessage>
    {
        public void Handle(MyMessage message)
        {
            throw new NotImplementedException();
        }
    }
}