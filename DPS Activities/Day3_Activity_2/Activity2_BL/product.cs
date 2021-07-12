using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity2_BL
{
    class product
    {
        public static int currentProductId;
        private string description;
        private double price;
        private string productId;
        private string productName;
        public string Description { get; set; }
        public double Price { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }

        static product()
        {
            currentProductId = 100;
        }
        public product()
        {
            productId = ("P" + currentProductId);
            currentProductId++;
            Console.WriteLine(productId);
        }
        public product(string productName, string description, double price)
        {

        }
    }
}

