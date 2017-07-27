using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.RestServiceTest
{
    public interface IRestServiceMethods
    {
        List<string> AddUser(string clientmsg1, string clientmsg2);
        List<string> DelUser(string clientmsg);
    }
}
