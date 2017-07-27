using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.RestServiceTest
{
    public interface IRestClientMethods
    {
        void GETALLUSERS();
        void GETONEUSER(string name);
        List<string> ADDUSER(string name1, string name2);
        List<string> DELETEUSER(string name);
        void UPDATEUSER(string name1, string name2, string name3);
    }
}
