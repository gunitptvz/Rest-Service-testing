using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace NUnit.RestServiceTest
{
    interface IHostCreate
    {
        ServiceHost HostCreate(Type servicetype, Type implementedcontract, Binding binding, string uriAddress);
    }
}
