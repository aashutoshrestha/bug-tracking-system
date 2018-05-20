using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting
{
    [TestClass]
    public class BugTrackingSystemTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool expectedresult = true;
            string username = "ayush";
            string password = "12345";

            BugTrackingSystem.UserController userController = new BugTrackingSystem.UserController();
            bool actualresult = userController.LoginUser(username,password);

            Assert.AreEqual(expectedresult, actualresult);

        }


        [TestMethod]
        public void TestMethod2()
        {
            bool expectedresult = false;
            string username = "ayush";
            string password = "123456";

            BugTrackingSystem.UserController userController = new BugTrackingSystem.UserController();
            bool actualresult = userController.LoginUser(username, password);

            Assert.AreEqual(expectedresult, actualresult);

        }

    }
}
