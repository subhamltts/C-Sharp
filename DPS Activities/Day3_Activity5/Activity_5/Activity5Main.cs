using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Activity5_BussinessLogic;

namespace Activity5
{
    class Activity5Main
    {
        static void Main(string[] args)
        {
            Employee obj = new SystemsEngineer("Java");
            Finance fObj = new Finance();
            Employee mObj = new Manager();
            Employee smObj = new SeniorProjectManager();

            Console.WriteLine(fObj.GetCalculatedSalary(obj));
            Console.WriteLine(fObj.GetCalculatedSalary(mObj));
            Console.WriteLine(fObj.GetCalculatedSalary(smObj));
        }
    }
}
