using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shopping_Management;
namespace Shopping_ManagementTest
{
    [TestClass]
    public class TestProduct
    {
        ProductHelper product = new ProductHelper();
        [TestMethod]
        public void TestInsertProductOK()
        {
            bool actual = product.InsertProduct(new Product(12343, "TestProduct", "Cai", 100, "1000", 1));
            Assert.AreEqual(actual, true, "Insert Test OK - OK");
        }

        [TestMethod]
        public void TestInsertProductNOTOK()
        {
            bool actual = product.InsertProduct(new Product(2005, "TestProduct", "Cai", 100, "1000", 1));
            Assert.AreEqual(actual, false, "Insert Test NOT OK - OK");
            
        }
        [TestMethod]
        public void TestDeleteProductOK()
        {
            bool actual = product.DeleteProduct(12343);
            Assert.AreEqual(actual, true, "Test Delete Product OK - OK");
        }

        [TestMethod]
        public void TestDeleteProductNOTOK()
        {
            bool actual = product.DeleteProduct(999999999);
            Assert.AreEqual(actual, false, "Test Delete Product NOT OK - OK");
        }
    }
}
