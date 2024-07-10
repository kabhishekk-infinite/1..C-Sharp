using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

// 1. Write a program in C# Sharp to append some text to an existing file. If file is not available, then create one. 
//  Hint: (Use the appropriate mode of operation. Use stream writer class).


namespace CCA_4
{
    class Stream_Writer
    {
        static void Main()
        {
            //Path of My File - ' Abhishek_Text_File '
            string filePath = @"D:\GitHub\1..C-Sharp\2. CCA\CCA-4/Abhishek_Text_File.txt";

            //Text to append in My File - ' Abhishek_Text_File '
            string newText = "This is the new line of text to append.";

            try
            {
                //Append or Create the file
                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    sw.WriteLine(newText);
                }

                if (File.Exists(filePath))                  
                {
                    Console.WriteLine("Text appended to existing file.");           //If Same file exits i.e, true then Text will be added in File.
                }
                else
                {
                    Console.WriteLine("New file created with the text.");           //If Same file doesn't exits i.e, false then new Text file will be created.
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);              //Shows Exceptions Message.
            }


            Console.WriteLine(" ");
            Console.WriteLine("~ ~ ~ Over ~ ~ ~ ");
            Console.WriteLine("Press any ekey to Exit. ");
            Console.ReadKey(); 
        }

    }
}
