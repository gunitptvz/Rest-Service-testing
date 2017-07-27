using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.RestServiceTest
{
   public class TestServicePrepair : IRestServiceMethods
    {
        IUser user;

        public TestServicePrepair(IUser user)
        {
            this.user = user;
        }

        public List<string>AddUser(string nickname, string fullname)
        {
            List<string> list = user.Add(nickname, fullname);

            return list;
        }

        public List<string>DelUser(string nickname)
        {
            List<string> list = user.Del(nickname);

            return list;
        }

    }

    public class User : IUser
    {

        public List<string> Add(string nickname, string fullname)
        {
            List<string> list = new List<string>();
            list.Add(nickname);
            list.Add(fullname);
            return list;
        }

        public List<string> Del(string nickname)
        {
            List<string> list = new List<string>();
            list.Add(nickname);
            list.Remove(nickname);
            return list;
        }

    }
}
