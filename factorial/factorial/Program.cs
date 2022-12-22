using System;
namespace factorial{
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter a Number");
            int num=Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            for(int i = 1; i <= num; i++)
            {
                fact= fact * i;
            }
                Console.WriteLine($"Factorial of {num} is {fact}");
        }
    }
}
