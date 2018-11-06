using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) //So you can try as many decimals as you want without closing the program :)
            {
                Console.WriteLine("Enter a binary like 1000 or 1001 or 1010 or etc..");

                string binary = Console.ReadLine();

                int decimalValue = Convert.ToInt32(binary, 2);

                if (decimalValue == Convert.ToInt32(binary, 2))
                {
                    Console.WriteLine("Success !");
                }
                else
                {
                    Console.WriteLine("Sorry something went wrong ask the developer for help !");
                }

                Console.WriteLine("Input value in base 10 = " + decimalValue);


            }
            Console.Read();
        }
    }
}
