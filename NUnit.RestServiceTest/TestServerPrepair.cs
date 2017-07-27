using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace NUnit.RestServiceTest
{
    public class TestServerPrepair : IHostCreate
    {
        public ServiceHost HostCreate(Type servicetype, Type implementedcontract, Binding binding, string uriAddress)
        {
            ServiceHost host = new ServiceHost(servicetype);

            host.AddServiceEndpoint(implementedcontract, binding, new Uri(uriAddress));

            return host;
        }
    }
}
