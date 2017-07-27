using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public interface IRestClientMethods
    {
        void GETALLUSERS();
        void GETONEUSER(string name);
        void ADDUSER(string name1, string name2);
        void DELETEUSER(string name);
        void UPDATEUSER(string name1, string name2, string name3);
    }
}
