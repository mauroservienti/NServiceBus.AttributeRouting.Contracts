<img src="assets/icon.png" width="100" />

# NServiceBus.AttributeRouting.Contracts

Enables to configure messages and commands routing by using attributes on message types:

```
[RouteTo("DestinationEndpoint")]
public class SampleMessage
{}
```

Refer to <https://github.com/mauroservienti/NServiceBus.AttributeRouting/> for instructions on how to configure endpoints to use attribute routing.

NOTE: Only [Messages and Commands](https://docs.particular.net/nservicebus/messaging/messages-events-commands) are supported. In NServiceBus Events are treated differently based on the underlying transport capabilities: If the transport supports native pub/sub (e.g. RabbitMQ or Azure Service Bus) everything is handled automatically, otherwise publishers needs to be manually registered. As of now registering publishers using attributes is not supported.

### Downloads

Nuget package: <https://www.nuget.org/packages/NServiceBus.AttributeRouting.Contracts/>

---

Icon: [route](https://thenounproject.com/search/?q=route&i=1720675) by [revo250](https://thenounproject.com/revo125cc/) from [the Noun Project](https://thenounproject.com/)

