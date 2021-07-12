using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity4BL
{
    public class Product
    {
        private Category category;
        public static int currentProductId;
        private string description;
        private double price;
        private string productId;
        private string productName;

        public Category Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public string ProductId
        {
            get
            {
                return productId;
            }
            set
            {
                productId = value;
            }
        }
        public string ProductName
        {
            get
            {
                return productName;
            }
            set
            {
                productName = value;
            }
        }

        static Product()
        {

        }
        public Product()
        {

        }
        public Product(string productName, string description, double price, Category category)
        {

        }
    }
}