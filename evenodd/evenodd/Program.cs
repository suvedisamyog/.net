using System;
namespace evenodd{
    internal class Program{
        static void Main(string[] args) {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0){
                Console.WriteLine("{ 0} is even", num);
            }else{
                Console.WriteLine("{0} is odd", num);
            }
            Console.ReadKey();
        }
    }
}
