using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity4BL
{
    public class Purchase
    {
        private Customer customer;
        private DateTime dateOfPurchase;
        private string paymentType;
        public static int purchaseCounter;
        private string purchaseId;
        private int quantityOrdered;
        private string shippingAddress;

        public DateTime DateOfPurchase
        {
            get
            {
                return dateOfPurchase;
            }
            set
            {
                dateOfPurchase = value;
            }
        }

        public string PaymentType
        {
            get
            {
                return paymentType;
            }
            set
            {
                paymentType = value;
            }
        }

        public string PurchaseId
        {
            get
            {
                return purchaseId;
            }
            set
            {
                purchaseId = value;
            }
        }

        public int QuantityOrdered
        {
            get
            {
                return quantityOrdered;
            }
            set
            {
                quantityOrdered = value;
            }
        }

        public string ShippingAddress
        {
            get
            {
                return shippingAddress;
            }
            set
            {
                shippingAddress = value;
            }
        }

        static Purchase()
        {

        }
        public Purchase()
        {

        }

        public Purchase(int quantityOrdered, string shippingAddress, DateTime dateOfPurchase, string paymentType)
        {

        }

        public double CalculateDiscount()
        {
            return 0.05;
        }
        public double CalculateBillAmount(params Product[] products)
        {
            double totalPrice = 0.0;
            foreach (Product price in products)
            {
                totalPrice += Convert.ToDouble(price);
            }

            double servTax = 0.07 * totalPrice;
            double discPercentage = CalculateDiscount();
            double totalBillAmount = ((totalPrice + servTax) * (1 - discPercentage));
            return totalBillAmount;
        }
        public double CalculateBillAmount(Product product, int quantityRequired)
        {
            double totalPrice = product.Price * quantityRequired;
            double serviceTax = 0.07 * totalPrice;
            double discountPercentage = CalculateDiscount();
            double totalBillAmount = ((totalPrice + serviceTax) * (1 - discountPercentage));
            return totalBillAmount;

        }
    }
}