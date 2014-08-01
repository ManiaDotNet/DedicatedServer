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
    /// Represents the structs returned by the GetCallVoteRatios and passed to the SetCallVoteRatios method calls.
    /// </summary>
    public sealed class CallVoteRatioStruct : BaseStruct
    {
        /// <summary>
        /// The ratio for disabled votes.
        /// </summary>
        public const int Disabled = -1;

        /// <summary>
        /// Backing field for the Command property.
        /// </summary>
        private readonly XmlRpcString command = new XmlRpcString();

        /// <summary>
        /// Backing field for the Ratio property.
        /// </summary>
        private readonly XmlRpcDouble ratio = new XmlRpcDouble();

        /// <summary>
        /// Gets or sets the name of the call-vote command that this ratio is for. * for all.
        /// </summary>
        public string Command
        {
            get { return command.Value; }
            set { command.Value = value; }
        }

        /// <summary>
        /// Gets or sets the Ratio for call-votes for this command. Range from 0-1, or Disabled.
        /// </summary>
        public double Ratio
        {
            get { return ratio.Value; }
            set
            {
                if (value != Disabled && (value < 0 || value > 1))
                    throw new ArgumentOutOfRangeException("value", "Ratio has to be between 0 and 1, or Disabled.");

                ratio.Value = value;
            }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Structs.CallVoteRatioStruct"/> class with the given ratio for the command.
        /// </summary>
        /// <param name="command">The name of the call-vote command that this ratio is for. * for all.</param>
        /// <param name="ratio">The ratio for call-votes for this command. Range from 0-1, or -1 for disabled.</param>
        public CallVoteRatioStruct(string command, double ratio)
        {
            Command = command;
            Ratio = ratio;
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Structs.CallVoteRatioStruct"/> class without content (for parsing from Xml).
        /// </summary>
        public CallVoteRatioStruct()
        { }

        /// <summary>
        /// Generates an XElement storing the information in this struct.
        /// </summary>
        /// <returns>The generated XElement.</returns>
        public override XElement GenerateXml()
        {
            return new XElement(XName.Get(XmlRpcElements.StructElement),
                makeMemberElement("Command", command),
                makeMemberElement("Ratio", ratio));
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
                case "Command":
                    if (!command.ParseXml(value))
                        return false;
                    break;

                case "Ratio":
                    if (!ratio.ParseXml(value))
                        return false;
                    break;

                default:
                    return false;
            }

            return true;
        }
    }
}