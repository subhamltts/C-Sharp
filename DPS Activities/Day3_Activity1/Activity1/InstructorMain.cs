using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Activity1_BussinessLogic;

namespace Activity1
{
    class InstructorMain
    {
        static void Main(string[] args)
        {
            Instructor inObj = new Instructor("Aquib", (float)4.2, 2, new string[]{"java","C#","Unit Testing"});

            Console.Write("Enter the technology:");
            string tech = Console.ReadLine();

            Console.WriteLine(inObj.CheckSkill(tech));

        }
    }
}
