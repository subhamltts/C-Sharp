using Microsoft.VisualStudio.TestTools.UnitTesting;
using Activity1_BussinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity1_BussinessLogic.Tests
{
    [TestClass()]
    public class InstructorTests
    {
        [TestMethod()]
        public void CheckSkillTestPositive1()
        {
            Instructor inObj = new Instructor("Aquib", (float)4.8, 5, new string[] { "Java", "C#", "Unit Testing" });
            bool actual = inObj.CheckSkill("C#");
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CheckSkillTestPositive2()
        {
            Instructor inObj = new Instructor("Aquib", (float)4.0, 2, new string[] { "Java", "C#", "Unit Testing" });
            bool actual = inObj.CheckSkill("Java");
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CheckSkillTestNegative1()
        {
            Instructor inObj = new Instructor("Aquib", (float)3.9, 2, new string[] { "Java", "C#", "Unit Testing" });
            bool actual = inObj.CheckSkill("Java");
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CheckSkillTestNegative2()
        {
            Instructor inObj = new Instructor("Aquib", (float)4.4, 5, new string[] { "Java", "C#", "Unit Testing" });
            bool actual = inObj.CheckSkill("Java");
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CheckSkillTestNegative3()
        {
            Instructor inObj = new Instructor("Aquib", (float)4.7, 4, new string[] { "Java", "C#", "Unit Testing" });
            bool actual = inObj.CheckSkill("C");
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CheckSkillTestNegative4()
        {
            Instructor inObj = new Instructor("Aquib", (float)4.1, 2, new string[] { "Java", "C#", "Unit Testing" });
            bool actual = inObj.CheckSkill("Python");
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }

    }
}