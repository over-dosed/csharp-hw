using System;

namespace csharp_hw_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,c,d = 0;
            Console.WriteLine("please input the first number:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("please input the second number:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("please input the sign:");
            c = Console.Read();
            switch (c)
            {
                case 42: d = a * b; break;
                case 43: d = a + b; break;
                case 45: d = a - b; break;
                case 47: d = a / b; break;
                default: break;
            }
            Console.WriteLine("the answer is : {0}",d);
        }
    }
}
