using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shopping_Management;

namespace Shopping_ManagementTest
{
    
    /// <summary>
    /// Summary description for UnitTest2
    /// </summary>
    /// 
    [TestClass]
    public class AddCustomerTest
    {
        CustomerHelper customer = new CustomerHelper();
        [TestMethod]
        public void AddCustomerTestOK()
        {
            bool actual = customer.AddNewCustomer(new Customer("TestName", "1992", 1, 1, "0989897677", "TestAddress"));
            bool expected = true;
            Assert.AreEqual(expected, actual, "Test Insert Customer OK - OK");
        }
    }
}
