using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HLReader.Model
{
    public class OpmlBody
    {
        [XmlElement(ElementName = "outline")]
        public Collection<OpmlOutline> Outline { get; set; }
    }
}
