using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ConsignmentShopLibrary
{
    public class Vendor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Commission { get; set; }
        public decimal  PaymentDue { get; set; }

        public string Display
        {
            get
            {
                return string.Format("{0} {1}- R${2}", FirstName, LastName, PaymentDue);
            }
        }

        public Vendor()
        {
            Commission = .5;
        }
    }
}
