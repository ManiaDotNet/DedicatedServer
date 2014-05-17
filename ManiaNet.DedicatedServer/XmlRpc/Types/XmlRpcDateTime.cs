using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.Types
{
    public class XmlRpcDateTime : XmlRpcType<DateTime>
    {
        public override string ElementName
        {
            get { return "dateTime.iso8601"; }
        }

        public override XElement GenerateXml()
        {
            string date = Value.Year.ToString() + Value.Month.ToString() + Value.Date.ToString() + "T" + Value.Hour.ToString() + ":" + Value.Minute.ToString() + ":" + Value.Second.ToString();

            return new XElement(XName.Get(ElementName), date);
        }

        public override XmlRpcType<DateTime> ParseXml(XElement xElement)
        {
            checkName(xElement);

            string date = xElement.Value; //formatted according to ISO-8601  yyyymmddThh:mm:ss  (the T is a literal).
            int yearLength = date.IndexOf('T') - 4;

            //Rudamentary check for correct format.
            if (!Regex.IsMatch(@"\d{" + yearLength + @"}[0-1]\d[0-1]\dT[0-2]\d:[0-5]\d:[0-5]\d", date))
                throw new FormatException("Ill formed ISO-8601 timestamp. Expected Format yyyymmddThh:mm:ss");

            int year = int.Parse(date.Remove(yearLength));
            int month = int.Parse(date.Remove(0, yearLength).Remove(2));
            int day = int.Parse(date.Remove(0, yearLength + 2).Remove(2));
            int hour = int.Parse(date.Remove(0, yearLength + 5).Remove(2));
            int minute = int.Parse(date.Remove(0, yearLength + 8).Remove(2));
            int second = int.Parse(date.Remove(yearLength + 11).Remove(2));

            Value = new DateTime(year, month, day, hour, minute, second);

            return this;
        }
    }
}