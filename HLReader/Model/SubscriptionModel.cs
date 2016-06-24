using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace HLReader.Model
{
    public class SubscriptionModel : ISubscriptions
    {
        public SubscriptionOpml LoadOpml(string path)
        {
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(SubscriptionOpml));
            SubscriptionOpml opml;
            using (var fs = new FileStream(path, FileMode.Open))
            {
                opml = serializer.Deserialize(fs) as SubscriptionOpml;
            }
            //var opml = new XmlDocument();
            //opml.Load(path);
            //return new SubscriptionOpml();
            //var opml = new SubscriptionOpml();
            //opml.Body = new OpmlBody
            //{
            //    Outline = new OpmlOutline
            //    {
            //        Text = "OutlineText1"
            //    }
            //};
            //opml.Header = new OpmlHeader
            //{
            //    Title = "HL Daemon Subscriptions",
            //    DateModified = DateTime.Now.ToUniversalTime()
            //};

            using (var fs = new FileStream(path + "my", FileMode.Create))
            {
                serializer.Serialize(fs, opml);
            }

            return opml;
        }
    }
}
