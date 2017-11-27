using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shopping_Management;

namespace Shopping_ManagementTest
{
    [TestClass]
    public class AuthenticationTest
    {
        AuthenticationHelper authentication = new AuthenticationHelper();

        [TestMethod]
        public void TestLogin1()
        {
            UserLogin login = authentication.CheckLogin(999, "nghinghi");
            bool actual = login == null ? false : true;
            bool expected = true;
            Assert.AreEqual(actual, expected, "Login Test OK - OK!");
        }

        [TestMethod]
        public void TestLogin2()
        {
            UserLogin login = authentication.CheckLogin(999, "testnotok");
            bool actual = login == null ? true : false;
            bool expected = true;
            Assert.AreEqual(actual, expected, "Login Test NOT OK - OK!");
            
        }
    }
}
