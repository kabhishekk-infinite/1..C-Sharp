using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Q. Create a Class Program which would be used to accepts two  Strings - FirstName and LastName and call the static method Display() that displays the first name in one line and the LastName in the second line after converting the same to upper case.
// Convert Name to UpperCase.
// => Accpt 2 string (FirstName and LastName) --> Call static method Display().
// => 'Display()' -> It will display FirstName in line 1 and LastName in line 2 with name changed into UpperCase.

namespace NameToUpperCase
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enter Data
            Console.Write(" Enter Your First Name : ");                     //Enter First Name.
            string fname = Console.ReadLine();

            Console.Write(" Enter Your Last Name : ");                      //Enter Last Name.
            string lname = Console.ReadLine();

            Console.WriteLine("\n");                                        //Add a Blank Line inbetween.

            //Calling the Static Method to display name.
            Display(fname, lname);                                          // 'Display()' - static method.
            

            /* ~ ~ ~ ~ These are only for Decoration Perpose ~ ~ ~ ~ */
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" ~ ~ Programs Execute Sucessfully ~ ~    ");
            Console.WriteLine("");
            Console.WriteLine(" ~ ~ ~ ~ END OF PROGRAM ~ ~ ~            ");
            Console.WriteLine(" Please Click Any Key To Exit.           ");
            Console.ReadKey();
        }


        //Static Method - Display - Name
        static void Display(string fname, string lname)
        {
            //Display Original Name.
            Console.WriteLine("   Original Input from User : - ");
            Console.WriteLine($"   First Name : {fname} ");
            Console.WriteLine($"   Last  Name : {lname} ");

            Console.WriteLine("\n");                                          //Add a Blank Line.

            //Display Name in UpperCase 
            Console.WriteLine("   Name After Changing Case :- ");

            string Lname = lname.ToUpper();         //Changes the Last Name into UpperCase and store it in diff string name - 'Lname'. Use 'String' Function : ' .ToUpper(). '

            //Now Print Name in UpperCase
            Console.WriteLine($"   First Name in UpperCase : {fname.ToUpper()} "); //Directly Change First name into UpperCase during output using 'String' function :  ' .ToUpper(). '
            Console.WriteLine($"   Last  Name in UpperCase : {Lname} ");
        }
    }

}
