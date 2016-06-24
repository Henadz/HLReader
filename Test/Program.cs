using HLReader.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new SubscriptionModel();
            //var opml = s.LoadOpml(@"d:\Projects\HLReader\data\test.opml");
            var opml = s.LoadOpml(@"d:\Projects\HLReader\data\subscriptions.opml");
        }
    }
}
