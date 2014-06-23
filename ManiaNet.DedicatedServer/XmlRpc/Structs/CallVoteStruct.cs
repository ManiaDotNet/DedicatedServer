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
    /// Represents the struct returned by the GetCurrentCallVote method call.
    /// </summary>
    public sealed class CallVoteStruct : BaseStruct
    {
        /// <summary>
        /// Backing field for the CallerLogin property.
        /// </summary>
        private XmlRpcString callerLogin = new XmlRpcString();

        /// <summary>
        /// Backing field for the CmdName property.
        /// </summary>
        private XmlRpcString cmdName = new XmlRpcString();

        /// <summary>
        /// Backing field for the CmdParam property.
        /// </summary>
        private XmlRpcString cmdParam = new XmlRpcString();

        /// <summary>
        /// Gets the Login of the player who started the call-vote.
        /// </summary>
        public string CallerLogin
        {
            get { return callerLogin.Value; }
        }

        /// <summary>
        /// Gets the Name of the command that the call-vote is for.
        /// </summary>
        public string CmdName
        {
            get { return cmdName.Value; }
        }

        /// <summary>
        /// Gets the parameter of the command that the call-vote is for.
        /// </summary>
        public string CmdParam
        {
            get { return cmdParam.Value; }
        }

        /// <summary>
        /// Generates an XElement storing the information in this struct.
        /// </summary>
        /// <returns>The generated XElement.</returns>
        public override XElement GenerateXml()
        {
            return new XElement(XName.Get(XmlRpcElements.StructElement),
                makeMemberElement("CallerLogin", callerLogin),
                makeMemberElement("CmdName", cmdName),
                makeMemberElement("CmdParam", cmdParam));
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
                case "CallerLogin":
                    if (!callerLogin.ParseXml(value))
                        return false;
                    break;

                case "CmdName":
                    if (!cmdName.ParseXml(value))
                        return false;
                    break;

                case "CmdParam":
                    if (!cmdParam.ParseXml(value))
                        return false;
                    break;

                default:
                    return false;
            }

            return true;
        }
    }
}