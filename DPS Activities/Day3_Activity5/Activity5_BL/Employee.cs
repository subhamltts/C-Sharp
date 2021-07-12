using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity5_BussinessLogic
{
    public class Employee
    {
        private double basicSalary;
        private double bonus;
        private int employeeId;

        public double BasicSalary {
            get
            {
                return basicSalary;
            }
            set
            {
                basicSalary = value;
            }
        }

        public double Bonus {
            get
            {
                return bonus;
            }
            set
            {
                bonus = value;
            }      
        }

        public int EmployeeId {
            get
            {
                return employeeId;
            }
            set
            {
                employeeId = value;
            }
                 
        }

        public Employee()
        {
            BasicSalary = 10000.0D;
        }

        public virtual double CalculateSalary()
        {
            return BasicSalary;
        }
    }

    public class SystemsEngineer : Employee
    {
        public double SpecialistAllowance { 
            get; set; 
        }

        public string Specialization { 
            get; set; 
        }

        public override double CalculateSalary()
        {
            if (Specialization == "C#" || Specialization == "Java" || Specialization == "SQL")
            {
                SpecialistAllowance = 3000.0D;
            }
            else
            {
                SpecialistAllowance = 0.0D;
            }

            double salary = BasicSalary + SpecialistAllowance;
            return salary;
        }

        public SystemsEngineer()
        {

        }

        public SystemsEngineer(string specialization)
        {
            if (specialization == null)
            {
                throw new ArgumentNullException("Specialization can not be null.");
            }
            Specialization = specialization;
        }
    }

    public class Manager : Employee
    {
        public double PhoneAllowance { 
            get; 
            set; 
        }

        public override double CalculateSalary()
        {
            double salary = BasicSalary + PhoneAllowance;

            return salary;
        }

        public Manager()
        {
            PhoneAllowance = 4000.0D;
        }
    }

    public class SeniorProjectManager : Employee
    {
        public double CarAllowance {
            get; 
            set; 
        }

        public override double CalculateSalary()
        {
            double salary = BasicSalary + CarAllowance;

            return salary;
        }

        public SeniorProjectManager()
        {
            CarAllowance = 6000.0D;
        }
    }

    public class Finance
    {
        public double GetCalculatedSalary(Employee obj)
        {

            if (obj.GetType() == typeof(SystemsEngineer))
            {
                obj.Bonus = 5000.0D;
            }
            else if (obj.GetType() == typeof(Manager))
            {
                obj.Bonus = 9000.0D;
            }
            else if (obj.GetType() == typeof(SeniorProjectManager))
            {
                obj.Bonus = 15000.0D;
            }
            else
            {
                obj.Bonus = 0.0D;
            }

            return obj.Bonus + obj.CalculateSalary();
        }
    }



}
