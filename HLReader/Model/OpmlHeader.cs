using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HLReader.Model
{
    public class OpmlHeader
    {
        [XmlElement(ElementName = "title")]
        public string Title { get; set; }

        [XmlElement(ElementName = "dateModified")]
        public string DateModifiedSerialized { get { return DateModified.ToString("r"); } set { DateModified = DateTime.Parse(value); } }

        [XmlIgnore]
        public DateTimeOffset DateModified { get; set; }
    }
}
