using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client;

namespace NUnit.RestServiceTest
{
    public class TestClientPrepair : IRestClientMethods
    {
        IRestServiceMethods service;

        public TestClientPrepair(IRestServiceMethods service)
        {
            this.service = service;
        }

        public List<string> ADDUSER(string a, string b)
        {
            List<string> result = service.AddUser(a, b);
            return result;
        }

        public List<string> DELETEUSER(string a)
        {
            List<string> result = service.DelUser(a);
            return result;
        }

        public void GETALLUSERS() { }
        public void GETONEUSER(string a) { }
        public void UPDATEUSER(string a, string b, string c) { }
    }
}
