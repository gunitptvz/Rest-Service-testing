using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using DataBase;

namespace Contract
{
    /// <summary>
    /// An interface with abstract methods
    /// </summary>
    [ServiceContract]
    public interface IContract
    {
        /// <summary>
        /// An abstract method for getting all user information
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        string GetAll();

        /// <summary>
        /// An abstract method for getting a user information
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        [OperationContract]
        string GetOne(string a);

        /// <summary>
        /// An abstract method for a user adding
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        [OperationContract]
        string AddUser(string a, string b);

        /// <summary>
        /// An abstract method for a user removing
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        [OperationContract]
        string DelUser(string a);

        /// <summary>
        /// An abstract method for a user updating
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        [OperationContract]
        string PutUser(string a, string b, string c);
    }

    class Contract
    {
        static void Main(string[] args)
        {

        }
    }
}
