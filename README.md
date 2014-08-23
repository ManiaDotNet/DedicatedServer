ManiaNet DedicatedServer
========================

This library contains all the required MethodCalls and Structs for interfacing with ManiaPlanet Dedicated Servers using the [XmlRpc](https://github.com/Banane9/XmlRpc) library.

An automatically generated Documentation of all the Types is avilable [here](http://maniadotnet.github.io/DedicatedServer), courtesy of [SharpDox](http://sharpdox.de).

The official documentation for all the methods offered by the Dedicated Server can be found [here](http://doc.maniaplanet.com/dedicated-server/xmlrpc/methods/latest.html).

---------------------------------------------------------------------------------------------------------------------------------

##Usage##

Simply `new` up an instance of the `XmlRpcClient` and you're ready to send/receive method calls.

``` CSharp
using ManiaNet.DedicatedServer.XmlRpc;
using ManiaNet.DedicatedServer.XmlRpc.Methods;

// You'll most likely have to change the port that is used (5000 is the default port - also used by the game)
var xmlRpcConnection = new XmlRpcClient(new XmlRpcClient.Config(port: 5001));

// If you don't care for the response, you don't have to store the returned handle.
var responseHandle = xmlRpcConnection.SendRequest(new Authenticate(login, password));

// If you do, just register for the MethodResponse event on the Client, and wait for the right handle to return.
// Then just parse the response into the right methodCall and it will contain the response.
xmlRpcConnection.MethodResponse += xmlRpcConnection_MethodResponse;
```


If you're using the [ManiaNet Server Controller](https://github.com/ManiaDotNet/ServerController), it's all done for you.

``` CSharp
var success = controller.CallMethod(methodCall, timeout);

if (success)
{
	// methodCall contains the response.
}
```

---------------------------------------------------------------------------------------------------------------------------------

##License##

#####[GPL V2](https://github.com/ManiaDotNet/DedicatedServer/blob/master/LICENSE.md)#####
