using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class ArrayCopyElements
    {
        static void Main(string[] args)
        {
            int[] originalArray = { 5, 0, 7, 4, 9 };

            int[] copiedArray = new int[originalArray.Length];

            for (int i = 0; i < originalArray.Length; i++)
            {
                copiedArray[i] = originalArray[i];
            }

            Console.WriteLine("Original Array: " + string.Join(", ", originalArray));

            Console.WriteLine("Copied Array: " + string.Join(", ", copiedArray));

            Console.ReadKey();
        }
    }
}
