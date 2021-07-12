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
    public class RegularCustomerTests
    {
        [TestMethod()]
        public void CustomerTest1()
        {
            DateTime dt1 = new DateTime(2000, 01, 02);
            RegularCustomer CObj1 = new RegularCustomer("Blue", "Lucknow", dt1, "blue@gmail.com", Customer.Enums.Gender.Male, "Abc123");

            DateTime dt2 = new DateTime(1999, 12, 12);
            RegularCustomer CObj2 = new RegularCustomer("Yellow", "Prayagraj", dt2, "yellow.com", Customer.Enums.Gender.Male, "Xyz123");

            Assert.AreNotSame(CObj1, CObj2);
        }
    }
}