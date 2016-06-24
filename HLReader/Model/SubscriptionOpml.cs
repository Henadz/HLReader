using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HLReader.Model
{
    [XmlRoot(ElementName ="opml")]
    public class SubscriptionOpml
    {
        [XmlElement(ElementName = "head")]
        public OpmlHeader Header { get; set; }
        [XmlElement(ElementName = "body")]
        public OpmlBody Body { get; set; }
    }
}
