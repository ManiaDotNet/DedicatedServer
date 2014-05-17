using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.Types.Structs
{
    public class XmlRpcApplicationVersionStruct : XmlRpcStruct<XmlRpcApplicationVersionStruct>
    {
        public XmlRpcString ApiVersion { get; private set; }

        public XmlRpcString Build { get; private set; }

        public XmlRpcString Name { get; private set; }

        public XmlRpcString TitleId { get; private set; }

        public XmlRpcString Version { get; private set; }

        public XmlRpcApplicationVersionStruct()
        {
            Name = new XmlRpcString();
            TitleId = new XmlRpcString();
            Version = new XmlRpcString();
            Build = new XmlRpcString();
            ApiVersion = new XmlRpcString();
        }

        public override IEnumerable<XElement> GenerateXml()
        {
            yield return makeMemberElement("Name", Name.GenerateXml());
            yield return makeMemberElement("TitleId", TitleId.GenerateXml());
            yield return makeMemberElement("Version", Version.GenerateXml());
            yield return makeMemberElement("Build", Build.GenerateXml());
            yield return makeMemberElement("ApiVersion", ApiVersion.GenerateXml());
        }

        public override XmlRpcApplicationVersionStruct ParseXml(XElement xElement)
        {
            checkName(xElement);

            foreach (XElement member in xElement.Descendants(XName.Get(MemberElement)))
            {
                checkIsValidMemberElement(member);

                XElement value = getMemberValueElement(member);

                switch (getMemberName(member))
                {
                    case "Name":
                        Name.ParseXml(getNormalizedStringValueContent(value, Name.ElementName));
                        break;

                    case "TitleId":
                        TitleId.ParseXml(getNormalizedStringValueContent(value, TitleId.ElementName));
                        break;

                    case "Version":
                        Version.ParseXml(getNormalizedStringValueContent(value, Version.ElementName));
                        break;

                    case "Build":
                        Build.ParseXml(getNormalizedStringValueContent(value, Build.ElementName));
                        break;

                    case "ApiVersion":
                        ApiVersion.ParseXml(getNormalizedStringValueContent(value, ApiVersion.ElementName));
                        break;

                    default:
                        throw new FormatException("Unexpected member with name " + getMemberName(member));
                }
            }

            return this;
        }
    }
}