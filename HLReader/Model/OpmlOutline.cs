using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HLReader.Model
{
    public class OpmlOutline
    {
        [XmlAttribute(AttributeName = "text")]
        public string Text { get; set; }
        [XmlAttribute(AttributeName = "title")]
        public string Title { get; set; }
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "xmlUrl")]
        public string XmlUrl { get; set; }
        [XmlAttribute(AttributeName = "htmlUrl")]
        public string HtmlUrl { get; set; }
        [XmlAttribute(AttributeName = "feedId", Namespace = "http://www.bradsoft.com/feeddemon/xmlns/1.0/")]
        public Guid FeedId { get; set; }
        [XmlAttribute(AttributeName = "folderId")]
        public string FolderId { get; set; }
        [XmlElement(ElementName = "outline")]
        public Collection<OpmlOutline> InnerOutline { get; set; }
    }
}