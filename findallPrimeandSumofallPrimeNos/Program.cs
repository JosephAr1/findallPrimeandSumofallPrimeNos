using System;

namespace findallPrimeandSumofallPrimeNos
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, sum = 0;
            int num, count = 0;

            for (num = 2; num <= 100; num++)
            {

                for (i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        count = count + 1;
                    }
                }
                if (count == 2)
                {
                    Console.WriteLine(num.ToString() + "  is a Prime  ");
                    sum = sum + num;
                }
                else
                {
                    Console.WriteLine(num.ToString() + "  is not a Prime ");
                }
                count = 0;

            }
            Console.WriteLine("Sum of all Prime numbers =" + sum.ToString());

        }
    }
}
