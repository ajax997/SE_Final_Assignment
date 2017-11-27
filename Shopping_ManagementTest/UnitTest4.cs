using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shopping_Management;
namespace Shopping_ManagementTest
{
    [TestClass]
    public class TestInvoice
    {
        InvoiceHelper helper = new InvoiceHelper();
        [TestMethod]
        public void TestCustomerExistOK()
        {
            bool actual = helper.CheckCustomerExist("0963661323") != "-1" ? true : false;
            Assert.AreEqual(actual, true, "Check Customer Exist OK - OK");
        }
        [TestMethod]
        public void TestCustomerExistNOTOK()
        {
            bool actual = helper.CheckCustomerExist("234234234234") != "-1" ? true : false;
            Assert.AreEqual(actual, false, "Check Customer Exist NOT OK - OK");
        }

        [TestMethod]
        public void TestCheckProductIDExsit()
        {
            bool actual = helper.CheckProductID(2005) != null ? true : false;
            Assert.AreEqual(actual, true, "Check Product Exist NOT OK - OK");
        }

        [TestMethod]
        public void TestCheckProductIDNOTExsit()
        {
            bool actual = helper.CheckProductID(23232) != null ? true : false;
            Assert.AreEqual(actual, false, "Check Product Exist NOT OK - OK");
        }

        [TestMethod]
        public void TestInsertInvoice()
        {
            bool actual = helper.InsertInvoice(new Invoice(1234224, 1233, "Nghi", 2434234, "1997", "123123", 23, "Cash"));
            Assert.AreEqual(actual, true, "Check Insert Product OK - OK");
        }
    }
}
