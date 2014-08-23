using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using XmlRpc;
using XmlRpc.Types;
using XmlRpc.Types.Structs;

namespace ManiaNet.DedicatedServer.XmlRpc.Structs
{
    /// <summary>
    /// Represents the structs returned from the GetManialinkPageAnswers method call.
    /// </summary>
    public sealed class ManialinkPageAnswerStruct : BaseStruct
    {
        /// <summary>
        /// Backing field for the Login property.
        /// </summary>
        private readonly XmlRpcString login = new XmlRpcString();

        /// <summary>
        /// Backing field for the PlayerId property.
        /// </summary>
        private readonly XmlRpcInt playerId = new XmlRpcInt(); //Probably actually an i4

        /// <summary>
        /// Backing field for the Result property.
        /// </summary>
        private readonly XmlRpcInt result = new XmlRpcInt();

        /// <summary>
        /// Gets the login of the player that this page answer is for.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string Login
        {
            get { return login.Value; }
        }

        /// <summary>
        /// Gets the id of the player that this page answer is for.
        /// </summary>
        [UsedImplicitly]
        public int PlayerId
        {
            get { return playerId.Value; }
        }

        /// <summary>
        /// Gets the answer of the page. 0 means no answer.
        /// </summary>
        [UsedImplicitly]
        public int Result
        {
            get { return result.Value; }
        }

        /// <summary>
        /// Generates an XElement storing the information in this struct.
        /// </summary>
        /// <returns>The generated XElement.</returns>
        public override XElement GenerateXml()
        {
            return new XElement(XName.Get(XmlRpcElements.StructElement),
                makeMemberElement("Login", login),
                makeMemberElement("PlayerId", playerId),
                makeMemberElement("Result", result));
        }

        /// <summary>
        /// Fills the property of this struct that has the correct name with the information contained in the member-XElement.
        /// </summary>
        /// <param name="member">The member element storing the information.</param>
        /// <returns>Whether it was successful or not.</returns>
        protected override bool parseXml(XElement member)
        {
            var value = getMemberValueElement(member);

            switch (getMemberName(member))
            {
                case "Login":
                    if (!login.ParseXml(value))
                        return false;
                    break;

                case "PlayerId":
                    if (!playerId.ParseXml(value))
                        return false;
                    break;

                case "Result":
                    if (!result.ParseXml(value))
                        return false;
                    break;

                default:
                    return false;
            }

            return true;
        }
    }
}