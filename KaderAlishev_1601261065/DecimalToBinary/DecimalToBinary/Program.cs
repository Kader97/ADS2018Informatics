using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) //So you can try as many decimals as you want without closing the program :)
            {
                Console.WriteLine("Enter a decimal like 1 or 2 or 3 or etc..");
                int value = int.Parse(Console.ReadLine());


                string binary = Convert.ToString(value, 2);
                if (binary == Convert.ToString(value, 2))
                {
                    Console.WriteLine("Success !");
                }
                else
                {
                    Console.WriteLine("Sorry this doesn't work ask the developer for help !");
                }
                Console.WriteLine(binary);
            }
            Console.Read();
        }
    }
}
