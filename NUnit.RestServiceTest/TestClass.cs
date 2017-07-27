using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.ServiceModel;
using System.ServiceModel.Channels;
using Rest_Service;
using Contract;
using Client;
using Moq;

namespace NUnit.RestServiceTest
{
    [TestFixture]
    public class Launch_Close_Service_Test_Class : TestServerPrepair
    {
        Type serviceType = typeof(MyService);
        Type implementedcontract = typeof(IContract);
        BasicHttpBinding binding = new BasicHttpBinding();
        string uriAddress = "http://localhost:150/IContract";

        [Test, Description("A host creation")]
        public void Host_Creation_Test()
        {
            TestServerPrepair testhost = new TestServerPrepair();

            ServiceHost host = testhost.HostCreate(serviceType, implementedcontract, binding, uriAddress);

            Assert.AreEqual("Created", host.State.ToString(), "The host didn't create");
        }

        [Test, Description("A host opening testing")]
        public void Open_Host_Test()
        {
            TestServerPrepair testhost = new TestServerPrepair();

            ServiceHost host = testhost.HostCreate(serviceType, implementedcontract, binding, uriAddress);

            host.Open();

            Assert.AreEqual("Opened", host.State.ToString(), "The host isn't opened");
        }

        [Test, Description("A host closing testing")]
        public void Close_Host_Test()
        {
            TestServerPrepair testhost = new TestServerPrepair();

            ServiceHost host = testhost.HostCreate(serviceType, implementedcontract, binding, uriAddress);

            host.Open();

            host.Close();

            Assert.AreEqual("Closed", host.State.ToString(), "The host isn't closed");
        }
    }

    [TestFixture]
    public class Create_Delete_Data_Class
    {
        string nickname = "Alex";
        string fullname = "Alexey";

        TestClientPrepair _testClientPrepair;
        TestServicePrepair _testServicePrepair;

        Mock<IRestServiceMethods> _mockRestServiceMethods;
        Mock<IUser> _mockUser;


        [Test, Description("User data adding")]
        public void Add_User_Data()
        {
            List<string> listexp = new List<string>();
            listexp.Add(nickname);
            listexp.Add(fullname);

            var repo = new MockRepository(MockBehavior.Default);
            _mockRestServiceMethods = repo.Create<IRestServiceMethods>();
            _mockUser = repo.Create<IUser>();
            _testClientPrepair = new TestClientPrepair(_mockRestServiceMethods.Object);
            _testServicePrepair = new TestServicePrepair(_mockUser.Object);

            _mockRestServiceMethods.Setup(x => x.AddUser(nickname, fullname));
            _mockUser.Setup(x => x.Add(nickname, fullname));

            IUser us1 = new User();
            List<string> listact = us1.Add(nickname, fullname);

            _testClientPrepair.ADDUSER(nickname, fullname);
            _testServicePrepair.AddUser(nickname, fullname);

            repo.Verify();
            CollectionAssert.AreEqual(listexp, listact);
            foreach (string item in listact) { Console.WriteLine(item); }
        }

        [Test, Description("User data removing")]
        public void Remove_User_Data()
        {
            List<string> listexp = new List<string>();

            var repo = new MockRepository(MockBehavior.Default);
            _mockRestServiceMethods = repo.Create<IRestServiceMethods>();
            _mockUser = repo.Create<IUser>();
            _testClientPrepair = new TestClientPrepair(_mockRestServiceMethods.Object);
            _testServicePrepair = new TestServicePrepair(_mockUser.Object);

            _mockRestServiceMethods.Setup(x => x.DelUser(nickname));
            _mockUser.Setup(x => x.Del(nickname));

            IUser us1 = new User();
            List<string> listact = us1.Del(nickname);

            _testClientPrepair.DELETEUSER(nickname);
            _testServicePrepair.DelUser(nickname);

            repo.Verify();
            CollectionAssert.AreEqual(listexp, listact);
        }
    }
}
