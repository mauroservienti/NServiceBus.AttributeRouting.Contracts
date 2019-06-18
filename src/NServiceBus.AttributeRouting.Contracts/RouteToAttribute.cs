using System;

namespace NServiceBus.AttributeRouting.Contracts
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class RouteToAttribute : Attribute
    {
        public RouteToAttribute(string destination)
        {
            Destination = destination;
        }

        public string Destination { get; private set; }
    }
}
