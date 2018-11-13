using System;

namespace RecursionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int baseNum, pwrNum;
            int result;
            Console.Write("\n\n Recursion \n");
            Console.Write("------------------------------------------------\n");

            Console.Write(" Enter number: ");
            baseNum = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Enter the ^ number: ");
            pwrNum = Convert.ToInt32(Console.ReadLine());

            result = CalcuOfPower(baseNum, pwrNum); //викане на функцията, съдържаща рекурсията

            Console.Write(" The result {0} after ^ of {1} is: {2} \n\n", baseNum, pwrNum, result);

            Console.Read();
        }

        public static int CalcuOfPower(int x, int y)
        {
            if (y == 0)
                return 1;
            else
                return x * CalcuOfPower(x, y - 1);
        }
    }
}
