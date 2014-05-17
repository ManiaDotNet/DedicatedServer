using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.Types.Structs
{
    public abstract class XmlRpcStruct<TXmlRpcStruct>
    {
        public const string ElementName = "struct";

        protected const string MemberElement = "member";

        protected const string NameElement = "name";

        protected const string ValueElement = "value";

        public abstract IEnumerable<XElement> GenerateXml();

        public abstract TXmlRpcStruct ParseXml(XElement xElement);

        protected void checkIsValidMemberElement(XElement member)
        {
            if (!member.Name.LocalName.Equals(MemberElement))
                throw new FormatException("Member Element has to have the name " + MemberElement);

            if (!member.HasElements)
                throw new FormatException("Member Element in struct has to have " + NameElement + " and " + ValueElement + " child-elements.");

            if (member.Element(XName.Get(NameElement)) == null)
                throw new FormatException("Member Element in struct has to have a " + NameElement + "child-element.");

            if (member.Element(XName.Get(ValueElement)) == null)
                throw new FormatException("Member Element in struct has to have a " + ValueElement + "child-element.");
        }

        protected void checkName(XElement xElement)
        {
            if (!xElement.Name.LocalName.Equals(ElementName))
                throw new ArgumentException("Element has to have the name " + ElementName, "xElement");
        }

        protected string getMemberName(XElement member)
        {
            checkIsValidMemberElement(member);

            return member.Element(XName.Get(NameElement)).Value;
        }

        protected XElement getMemberValueElement(XElement member)
        {
            checkIsValidMemberElement(member);

            return member.Element(XName.Get(ValueElement));
        }

        //Value tags with only content that is not inside another tag are string by default
        protected XElement getNormalizedStringValueContent(XElement value, string stringElement)
        {
            if (!value.Name.LocalName.Equals(ValueElement))
                throw new FormatException("Value Element has to have the name " + ValueElement);

            if (value.HasElements)
                return value.Element(XName.Get(stringElement));

            return new XElement(XName.Get(stringElement), value.Value);
        }

        protected XElement makeMemberElement(string name, XElement value)
        {
            return new XElement(XName.Get("member"), makeNameXElement(name), makeValueXElement(value));
        }

        private XElement makeNameXElement(string name)
        {
            return new XElement(XName.Get(NameElement), name);
        }

        private XElement makeValueXElement(XElement value)
        {
            return new XElement(XName.Get(ValueElement), value);
        }
    }
}