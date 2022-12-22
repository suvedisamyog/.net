using System;
namespace operators{
    internal class Program {
        static void Main(string[] args){
            Console.WriteLine("Enter First Number");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            int b=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("................");
            Console.WriteLine("{0}+{1}={2}\n{3}-{4}={5}", a,b,a+b ,a,b,a-b);
            Console.WriteLine("{0}+{1}={2}\n{3}-{4}={5}", a, b, a * b, a, b, a / b);
        }
    }
}
