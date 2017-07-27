using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.RestServiceTest
{
    public interface IUser
    {
        List<string> Add(string a, string b);
        List<string> Del(string a);
    }
}
