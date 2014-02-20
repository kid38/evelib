﻿using System;
using System.Xml.Serialization;

namespace eZet.Eve.EveApi.Dto.EveApi.Character {
    public class MailBodies : XmlResult {

        [XmlElement("rowset")]
        public XmlRowSet<Message> Messages { get; set; }

        [XmlElement("missingMessageIDs")]
        public string MissingMessageIds { get; set; }

        [Serializable]
        [XmlRoot("row")]
        public class Message {
            
            [XmlAttribute("messageID")]
            public long MessageId { get; set; }

            [XmlText]
            public string MessageData { get; set; }

        }
    }
}