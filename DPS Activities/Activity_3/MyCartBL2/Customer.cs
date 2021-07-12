using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCartBL2
{
    public class Customer
    {   public enum CustomerCardType
        {
            Silver,
            Gold,
            Platinum
        }
        public class Enums {
            public enum Gender {
                Male,
                Female,
                Other
            }
        }
        private string address;
        public static int currentValueForCustomerId;
        private int customerId;
        private string customerName;
        private DateTime dateOfBirth;
        private string emailId;
        private Enums.Gender gender;
        private string password;
        public string Address { get { return address; } set { address = value; } }
        public int CustomerId { get { return customerId; } set { customerId = value; } }
        public string CustomerName { get { return customerName; } set { customerName = value; } }
        public DateTime DateOfBirth { get { return dateOfBirth; } set { dateOfBirth = value; } }
        public string EmailId { get { return emailId; } set { emailId = value; } }
        public Enums.Gender Gender { get { return gender; } set { gender = value; } }
        public string Password { get { return password; } set { password = value; } }

        static Customer()
        {
            currentValueForCustomerId = 1000;
        }
        public Customer()
        {
            customerId = currentValueForCustomerId;
            currentValueForCustomerId++;
            Console.WriteLine(customerId);
        }

        public Customer(string customerName, string address, DateTime dateOfBirth, string emailId, Enums.Gender gender, string password)
        {
            customerName = this.customerName;
            address = this.address;
            dateOfBirth = this.dateOfBirth;
            emailId = this.emailId;
            gender = this.gender;
            password = this.password;
        }
    }
}
