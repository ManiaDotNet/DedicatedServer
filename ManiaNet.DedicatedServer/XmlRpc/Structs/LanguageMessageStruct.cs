﻿using ManiaNet.DedicatedServer.Annotations;
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
    /// Represents the structs passed to the ChatSendServerMessageToLanguage and ChatSendToLanguage method calls.
    /// </summary>
    public sealed class LanguageMessageStruct : BaseStruct
    {
        /// <summary>
        /// Backing field for the Lang property.
        /// </summary>
        private readonly XmlRpcString lang = new XmlRpcString();

        /// <summary>
        /// Backing field for the Text property.
        /// </summary>
        private readonly XmlRpcString text = new XmlRpcString();

        /// <summary>
        /// Gets or sets the two letter language code for this message.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string Lang
        {
            get { return lang.Value; }
            set
            {
                if (value.Length != 2)
                    throw new FormatException("Language has to be a two letter code.");

                lang.Value = value;
            }
        }

        /// <summary>
        /// Gets or sets the Text for this message.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string Text
        {
            get { return text.Value; }
            set { text.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Structs.LanguageMessageStruct"/> class without content (for parsing from Xml).
        /// </summary>
        public LanguageMessageStruct()
        { }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Structs.LanguageMessageStruct"/> class with the given text for the given language.
        /// </summary>
        /// <param name="lang">The two letter language code that this message is for.</param>
        /// <param name="text">The content of this message.</param>
        public LanguageMessageStruct([NotNull] string lang, [NotNull] string text)
        {
            Lang = lang;
            Text = text;
        }

        /// <summary>
        /// Generates an XElement storing the information in this struct.
        /// </summary>
        /// <returns>The generated XElement.</returns>
        public override XElement GenerateXml()
        {
            return new XElement(XName.Get(XmlRpcElements.StructElement),
                makeMemberElement("Lang", lang),
                makeMemberElement("Text", text));
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
                case "Lang":
                    if (!lang.ParseXml(value))
                        return false;
                    break;

                case "Text":
                    if (!text.ParseXml(value))
                        return false;
                    break;

                default:
                    return false;
            }

            return true;
        }
    }
}