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
    /// Represents the struct returned by the GetBillState method call.
    /// </summary>
    public sealed class BillStateStruct : BaseStruct
    {
        /// <summary>
        /// Backing field for the State property.
        /// </summary>
        private readonly XmlRpcI4 state = new XmlRpcI4();

        /// <summary>
        /// Backing field for the StateName property.
        /// </summary>
        private readonly XmlRpcString stateName = new XmlRpcString();

        /// <summary>
        /// Backing field for the TransactionId property.
        /// </summary>
        private readonly XmlRpcI4 transactionId = new XmlRpcI4();

        /// <summary>
        /// Gets the code for the current status of the transaction.
        /// </summary>
        [UsedImplicitly]
        public int State
        {
            get { return state.Value; }
        }

        /// <summary>
        /// Gets the name of the current status of the transaction.
        /// <para/>
        /// Possible values: CreatingTransaction, Issued, ValidatingPayement [sic], Payed, Refused, Error.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string StateName
        {
            get { return stateName.Value; }
        }

        /// <summary>
        /// Gets the Id of the transaction.
        /// </summary>
        [UsedImplicitly]
        public int TransactionId
        {
            get { return transactionId.Value; }
        }

        /// <summary>
        /// Generates an XElement storing the information in this struct.
        /// </summary>
        /// <returns>The generated XElement.</returns>
        public override XElement GenerateXml()
        {
            return new XElement(XName.Get(XmlRpcElements.StructElement),
                makeMemberElement("State", state),
                makeMemberElement("StateName", stateName),
                makeMemberElement("TransactionId", transactionId));
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
                case "State":
                    if (!state.ParseXml(value))
                        return false;
                    break;

                case "StateName":
                    if (!stateName.ParseXml(value))
                        return false;
                    break;

                case "TransactionId":
                    if (!transactionId.ParseXml(value))
                        return false;
                    break;

                default:
                    return false;
            }

            return true;
        }
    }
}