using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLReader.Model
{
    public interface ISubscriptions
    {
        SubscriptionOpml LoadOpml(string path);
    }
}
