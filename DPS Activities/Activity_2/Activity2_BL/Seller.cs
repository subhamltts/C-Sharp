using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity2_BL
{
    class Seller
    {
        private string sellerId;
        public static int sellerIdCount;
        private string sellerName;
        public string SellerId { get; set; }
        public string[] SellerLocations { get; set; }
        public string SellerName { get; set; }
        static Seller()
        {
            sellerIdCount = 1001;
        }
        public Seller()
        {
            sellerId = ("S" + sellerIdCount);
            sellerIdCount++;
            Console.WriteLine(sellerId);
        }
        public Seller(string sellerName)
        {

        }
    }
}

