using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity2_BL
{
    class Purchase
    {
        private static DateTime dateOfPurchase;
        private static string paymentType;
        public static int purchaseCounter;
        private string purchaseId;
        private int quantityOrdered;
        private string shippingAddress;
        public DateTime DateOfPurchase { get { return dateOfPurchase; } set { dateOfPurchase = value; } }
        public string PaymentType { get { return paymentType; } set { paymentType = value; } }
        public string PurchaseId { get { return purchaseId; } set { purchaseId = value; } }
        public int QuantityOrdered { get { return quantityOrdered; } set { quantityOrdered = value; } }
        public string ShippingAddress { get { return shippingAddress; } set { shippingAddress = value; } }

        static Purchase()
        {
            purchaseCounter = 1001;
        }
        public Purchase()
        {
            purchaseId = ("B" + purchaseCounter);
            purchaseCounter++;
            Console.WriteLine(purchaseId);
        }
        public Purchase(int quantityOrdered, string shippingAddress, DateTime dateOfPurchase, string paymentType)
        {

        }
        public double CalculateBillAmount(double price)
        {
            return 0;
        }
        public double CalculateBillAmount(double price, double discountPercentage)
        {
            return 0;
        }
        public static double GetPurchasePercentage(DateTime[] transactionDates, DateTime dateForReport)
        {
            int count = 0;
            for (int i = 0; i < transactionDates.Length; i++)
            {
                transactionDates[i] = dateOfPurchase;
                if (transactionDates[i] == dateForReport)
                {
                    count++;
                }

            }
            double purchasePercentage = count / transactionDates.Length * 100;
            return purchasePercentage;
        }
        public static double RoundOffBill(double amount)
        {
            return (Math.Round(amount, 2));
        }
    }
}

