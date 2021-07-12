using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCartBL2
{
    public class PrivilegedCustomer : Customer
    {
        private CustomerCardType cardType;
        public CustomerCardType CardType { get { return cardType; } set { cardType = value; } }
        public PrivilegedCustomer(string customerName,string address,DateTime dateOfBirth,string emailId,Enums.Gender Gender,string password, CustomerCardType cardType)
        {
            cardType = this.cardType;
        }
    }
}
