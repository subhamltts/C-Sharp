using Microsoft.VisualStudio.TestTools.UnitTesting;
using Activity5_BussinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity5_BussinessLogic.Tests
{
    [TestClass()]
    public class FinanceTests
    {
        [TestMethod()]
        public void GetCalculatedSalaryTestPositive1()
        {
            Employee obj = new SystemsEngineer("Java");
            Finance fObj = new Finance();
            double actual = fObj.GetCalculatedSalary(obj);
            double expected = 18000.0D;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetCalculatedSalaryTestPositive2()
        {
            Employee obj = new SystemsEngineer("C#");
            Finance fObj = new Finance();
            double actual = fObj.GetCalculatedSalary(obj);
            double expected = 18000.0D;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetCalculatedSalaryTestPositive3()
        {
            Employee obj = new SystemsEngineer();
            Finance fObj = new Finance();
            double actual = fObj.GetCalculatedSalary(obj);
            double expected = 15000.0D;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetCalculatedSalaryTestPositive4()
        {
            Employee mobj = new Manager();
            Finance fObj = new Finance();
            double actual = fObj.GetCalculatedSalary(mobj);
            double expected = 23000.0D;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetCalculatedSalaryTestPositive5()
        {
            Employee smobj = new SeniorProjectManager();
            Finance fObj = new Finance();
            double actual = fObj.GetCalculatedSalary(smobj);
            double expected = 31000.0D;
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void GetCalculatedSalaryTestPositive6()
        {
            Employee obj = new Employee();
            Finance fObj = new Finance();
            double actual = fObj.GetCalculatedSalary(obj);
            double expected = 10000.0D;
            Assert.AreEqual(expected, actual);
        }




    }
}