using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCartBL2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCartBL2.Tests
{
    [TestClass()]
    public class PrivilegedCustomerTests
    {
        [TestMethod()]
        public void PrivilegedCustomerTest1()
        {
            DateTime dt1 = new DateTime(2000, 01, 02);
            PrivilegedCustomer PCObj1 = new PrivilegedCustomer("Blue", "Lucknow", dt1, "blue@gmail.com", Customer.Enums.Gender.Male, "Abc123",Customer.CustomerCardType.Silver);

            DateTime dt2 = new DateTime(1999, 12, 12);
            PrivilegedCustomer PCObj2 = new PrivilegedCustomer("Yellow", "Prayagraj", dt2, "yellow.com", Customer.Enums.Gender.Male, "Xyz123",Customer.CustomerCardType.Gold);

            Assert.AreNotSame(PCObj1, PCObj2);
        }
        [TestMethod()]
        public void PrivilegedCustomerTest2()
        {
            DateTime dt1 = new DateTime(2000, 01, 02);
            PrivilegedCustomer PCObj1 = new PrivilegedCustomer("Blue", "Lucknow", dt1, "blue@gmail.com", Customer.Enums.Gender.Male, "Abc123", Customer.CustomerCardType.Silver);

            PrivilegedCustomer PCObj2 = new PrivilegedCustomer("Blue", "Lucknow", dt1, "blue@gmail.com", Customer.Enums.Gender.Male, "Abc123", Customer.CustomerCardType.Silver);

            Assert.AreNotSame(PCObj2, PCObj1);
        }
    }
}