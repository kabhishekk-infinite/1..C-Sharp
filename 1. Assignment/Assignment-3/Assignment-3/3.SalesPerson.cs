using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class SaleDetails
    {
        //Data members
        private int salesNo;
        private int productNo;
        private double price;
        private DateTime dateOfSale;
        private int qty;
        private double totalAmount;

        //Constructor- Sale Details 's Initialization
        public SaleDetails(int salesNo, int productNo, double price, int qty, DateTime dateOfSale)
        {
            this.salesNo = salesNo;
            this.productNo = productNo;
            this.price = price;
            this.qty = qty;
            this.dateOfSale = dateOfSale;

            //For Total Amount
            Sales();
        }

        //Method- Total Amount
        private void Sales()
        {
            totalAmount = qty * price;
        }

        //Method- Sale Details
        public void ShowData()
        {
            Console.WriteLine($"Sales Number: {salesNo}");
            Console.WriteLine($"Product Number: {productNo}");
            Console.WriteLine($"Price per unit: {price}");
            Console.WriteLine($"Quantity sold: {qty}");
            Console.WriteLine($"Date of Sale: {dateOfSale.ToShortDateString()}");
            Console.WriteLine($"Total Amount: {totalAmount}");
        }
    }

    class SalesPerson
    {
        static void Main()
        {
            DateTime date1 = new DateTime(2024, 6, 20);
            SaleDetails sale1 = new SaleDetails(1, 101, 25.5, 5, date1);
            sale1.ShowData();

            Console.WriteLine();

            DateTime date2 = new DateTime(2024, 6, 21);
            SaleDetails sale2 = new SaleDetails(2, 102, 30.75, 10, date2);
            sale2.ShowData();

            Console.ReadLine();
        }
    }
}
