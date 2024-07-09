using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCA_2
{
    class Products                                                        //Class name with Products
    {
        public int Productid { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
    }

    class SortProduct                                                    //Class with name SortProduct
    {
        static void Main()
        {
            //List to accept 10 Product name 'products'
            List<Products> products = new List<Products>();

            //Accept 10 products
            for (int i = 1; i <= 10; i++)
            {
                Products p = new Products();
                p.Productid = i;                                        //Store each product with product id according to i
                Console.Write($" Enter name for product {i}: ");
                p.ProductName = Console.ReadLine();                     //Store product name which use will input
                Console.Write($" Enter price for product {i}: ");
                p.ProductPrice = decimal.Parse(Console.ReadLine());     //Store price of product which user will input
                products.Add(p);
            }

            //Using Bubble Sort Method for SOrting in Ascending order.
            BubbleSort(products);

            //Display Sorted Products.
            Console.WriteLine("\n\n Sorted Products by Price:");
            foreach (var product in products)
            {
                Console.WriteLine($" Product ID: {product.Productid},   Name: {product.ProductName},   Price: {product.ProductPrice}");
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" ~ ~ ~ ~ Programs Execute Sucessfully. ~ ~ ~ ~ ");
            Console.WriteLine(" Please Click Any Key To Exit.    ");
            Console.ReadKey();
        }

        //Bubble Sort Implementation
        static void BubbleSort(List<Products> products)
        {
            int n = products.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (products[j].ProductPrice > products[j + 1].ProductPrice)
                    {
                        // Swap products[j] and products[j + 1]
                        Products temp = products[j];
                        products[j] = products[j + 1];
                        products[j + 1] = temp;
                    }
                }
            }
        }
    }
}
