using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.ServiceModel;
using Contract;
using Newtonsoft.Json;

namespace Client
{
    /// <summary>
    /// An implementation of IProvider interface
    /// </summary>
    public class RestClientMethods
    {
        IRestClientMethods restclientmethods;
        ChannelFactory<IContract> channelfactory;

        /// <summary>
        /// This method gets and deserializes service message with all users information
        /// </summary>
        public void GETALLUSERS()
        {
            ChannelFactory<IContract> channelfactory = new ChannelFactory<IContract>(new BasicHttpBinding(), new EndpointAddress("http://localhost:150/IContract"));
            IContract proxy = channelfactory.CreateChannel();
            string result = proxy.GetAll();
            object deserialized = JsonConvert.DeserializeObject(result);
            Console.WriteLine(deserialized);
        }

        /// <summary>
        /// This method gets and deserializes service message with user information
        /// </summary>
        /// <param name="name"></param>
        public void GETONEUSER(string name)
        {
            ChannelFactory<IContract> channelfactory = new ChannelFactory<IContract>(new BasicHttpBinding(), new EndpointAddress("http://localhost:150/IContract"));
            IContract proxy = channelfactory.CreateChannel();
            string result1 = proxy.GetOne(name);
            object deserialized1 = JsonConvert.DeserializeObject(result1);
            Console.WriteLine(deserialized1);
        }

        /// <summary>
        /// This method gets and deserializes service message with add user procedure information
        /// </summary>
        /// <param name="name1"></param>
        /// <param name="name2"></param>
        public void ADDUSER(string name1, string name2)
        {
            ChannelFactory<IContract> channelfactory = new ChannelFactory<IContract>(new BasicHttpBinding(), new EndpointAddress("http://localhost:150/IContract"));
            IContract proxy = channelfactory.CreateChannel();
            string result2 = proxy.AddUser(name1, name2);
            object deserialized2 = JsonConvert.DeserializeObject(result2);
            Console.WriteLine(deserialized2);
        }

        /// <summary>
        /// This method gets and deserializes service message with delete user procedure information
        /// </summary>
        /// <param name="name"></param>
        public void DELETEUSER(string name)
        {
            ChannelFactory<IContract> channelfactory = new ChannelFactory<IContract>(new BasicHttpBinding(), new EndpointAddress("http://localhost:150/IContract"));
            IContract proxy = channelfactory.CreateChannel();
            string result3 = proxy.DelUser(name);
            object deserialized3 = JsonConvert.DeserializeObject(result3);
            Console.WriteLine(deserialized3);
        }

        /// <summary>
        /// This method gets and deserializes service message with update user procedure information
        /// </summary>
        /// <param name="name1"></param>
        /// <param name="name2"></param>
        /// <param name="name3"></param>
        public void UPDATEUSER(string name1, string name2, string name3)
        {
            ChannelFactory<IContract> channelfactory = new ChannelFactory<IContract>(new BasicHttpBinding(), new EndpointAddress("http://localhost:150/IContract"));
            IContract proxy = channelfactory.CreateChannel();
            string result4 = proxy.PutUser(name1, name2, name3);
            object deserialized4 = JsonConvert.DeserializeObject(result4);
            Console.WriteLine(deserialized4);
        }
    }
}
