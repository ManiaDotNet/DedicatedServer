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
    /// Represents the struct returned by the GetDemoTokenInfosForPlayer method call.
    /// </summary>
    public sealed class DemoTokenInfosStruct : BaseStruct
    {
        /// <summary>
        /// Backing field for the CanPayToken property.
        /// </summary>
        private readonly XmlRpcBoolean canPayToken = new XmlRpcBoolean();

        /// <summary>
        /// Backing field for the TokenCost property.
        /// </summary>
        private readonly XmlRpcI4 tokenCost = new XmlRpcI4();

        /// <summary>
        /// Gets whether the player can pay for the token or not.
        /// </summary>
        public bool CanPayToken
        {
            get { return canPayToken.Value; }
        }

        /// <summary>
        /// Gets the token cost.
        /// </summary>
        public int TokenCost
        {
            get { return tokenCost.Value; }
        }

        /// <summary>
        /// Generates an XElement storing the information in this struct.
        /// </summary>
        /// <returns>The generated XElement.</returns>
        public override XElement GenerateXml()
        {
            return new XElement(XName.Get(XmlRpcElements.StructElement),
                makeMemberElement("TokenCost", tokenCost),
                makeMemberElement("CanPayToken", canPayToken));
        }

        /// <summary>
        /// Fills the property of this struct that has the correct name with the information contained in the member-XElement.
        /// </summary>
        /// <param name="member">The member element storing the information.</param>
        /// <returns>Whether it was successful or not.</returns>
        protected override bool parseXml(XElement member)
        {
            XElement value = getMemberValueElement(member);

            switch (getMemberName(member))
            {
                case "TokenCost":
                    if (!tokenCost.ParseXml(value))
                        return false;
                    break;

                case "CanPayToken":
                    if (!canPayToken.ParseXml(value))
                        return false;
                    break;

                default:
                    return false;
            }

            return true;
        }
    }
}