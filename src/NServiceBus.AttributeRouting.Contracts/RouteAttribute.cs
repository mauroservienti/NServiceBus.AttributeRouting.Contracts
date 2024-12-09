using System;

namespace NServiceBus.AttributeRouting
{
    [AttributeUsage(AttributeTargets.Assembly)]
    public class RouteAttribute : Attribute
    {
        public RouteAttribute(string commandsTo = null, string messagesTo = null)
        {
            CommandsDestination = commandsTo;
            MessagesDestination = messagesTo;
        }

        public string CommandsDestination { get; }
        public string MessagesDestination { get; }
    }
}