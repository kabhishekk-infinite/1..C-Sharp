using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Customer
    {
        //Data Members
        private int customerId;
        private string name;
        private int age;
        private string phone;
        private string city;

        // Constructor- No_arguments
        public Customer()
        {
            Console.WriteLine("Default constructor called.");
        }

        //Constructor- All_Information
        public Customer(int customerId, string name, int age, string phone, string city)
        {
            this.customerId = customerId;
            this.name = name;
            this.age = age;
            this.phone = phone;
            this.city = city;
            Console.WriteLine("Parameterized constructor called.");
        }

        //Method- Display Customer_Details
        public void DisplayCustomer()
        {
            Console.WriteLine($"Customer ID: {customerId}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Phone: {phone}");
            Console.WriteLine($"City: {city}");
        }

        //Destructor
        ~Customer()
        {
            Console.WriteLine($"Destructor called for Customer {customerId}");
        }

        //Static-Method Display_Customer_Details
        public static void DisplayCustomerStatic(Customer customer)
        {
            customer.DisplayCustomer();
        }
    }

    class CustomerDetails
    {
        static void Main()
        {
            // Using constructor
            Customer customer1 = new Customer(1035480, "Abhishek Kumar", 25, "8083552817", "Bangalore");
            customer1.DisplayCustomer();

            Console.WriteLine();

            // Using default constructor
            Customer customer2 = new Customer();
            customer2.DisplayCustomer();

            Console.WriteLine();

            // Static method 
            Customer.DisplayCustomerStatic(customer1);

            // Destructor will be called when objects go out of scope
            Console.ReadKey();
        }
    }
}
