using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity2_BL
{
    public class Customer
    {
        private string address;
        public static int ValueofCustomerID;
        private int customerid;
        private string customername;
        private string customertype;
        private DateTime dateofbirth;
        private string emailid;
        private Enum.Gender gender;
        private string password;
        public class Enum
        {
            public enum Gender
            {
                Male,
                Female,
                Other
            }
        }
        public string Address 
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        public int Customerid 
        {
            get
            {
                //Customerid =+1;
                return customerid;
            }
            set
            {
                customerid = value;
            }
        }
        public string CustomerName
        {
            get
            {
                return customername;
            }
            set
            {
                customername = value;
            }

        }
        public string Customertype
        {
            get
            {
                return customertype;
            }
            set
            {
                customertype = value;
            }

        }
        public DateTime Dateofbirth
        {
            get
            {
                return dateofbirth;
            }
            set
            {
                dateofbirth = value;
            }

        }
        public string Emailid
        {
            get
            {
                return emailid;
            }
            set
            {
                emailid = value;
            }

        }
        public string Gender
        {
            get
            {
                return gender;

            }
            set
            {
               gender = values;
            }

        }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }

        }

        static Customer()
        {
            ValueofCustomerID = 1000;
        }
        public Customer()
        {
            customerid = ValueofCustomerID;
            ValueofCustomerID++;
            Console.WriteLine(customerid);
        }
        public Customer(string customername , string address , DateTime dateofbirth, string emailid,Enum.Gender gender, string password,string customertype )
        {
            customername = this.customername;
            address = this.address;
            dateofbirth = this.dateofbirth;
            emailid = this.emailid;
            gender = this.gender;
            password = this.password;
            customertype = this.customertype;
        }
        public double GetDiscount()
        {
            double discount = 0.0;
            return discount;
        }



    }
}
