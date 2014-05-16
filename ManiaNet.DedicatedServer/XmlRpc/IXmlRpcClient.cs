using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc
{
    /// <summary>
    /// EventHandler for the MethodResponse event.
    /// </summary>
    /// <param name="requestHandle">The handle of the method call that the response is for.</param>
    /// <param name="methodResponse">The xml formatted content of the method response.</param>
    public delegate void MethodResponseEventHandler(uint requestHandle, string methodResponse);

    /// <summary>
    /// EventHandler for the ServerCallback event.
    /// </summary>
    /// <param name="serverCallback">The xml formatted content of the method response.</param>
    public delegate void ServerCallbackEventHandler(string serverCallback);

    public interface IXmlRpcClient
    {
        /// <summary>
        /// Open a connection to an XmlRpc interface.
        /// </summary>
        void Connect();

        /// <summary>
        /// Start reading data from the interface connection.
        /// </summary>
        void Receive();

        /// <summary>
        /// Send a xml formatted request to the XmlRpc interface.
        /// </summary>
        /// <param name="request">The xml formatted request.</param>
        /// <returns>The handle associated with the request.</returns>
        uint SendRequest(string request);

        /// <summary>
        /// Fires when a MethodResponse is received.
        /// </summary>
        event MethodResponseEventHandler MethodResponse;

        /// <summary>
        /// Fires when a ServerCallback is received.
        /// </summary>
        event ServerCallbackEventHandler ServerCallback;
    }
}