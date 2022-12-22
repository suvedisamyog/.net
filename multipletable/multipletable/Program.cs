using System;
namespace multipletable{
    internal class Program{
        static void Main(string[] args)
        {
            Console.WriteLine("Enate a number");
            int num=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The multiplication table of {0}:",num);
            for(int i=0; i <= 10; i++){
                Console.WriteLine("{0}*{1}={2}", num, i, num * i);
            }
        }
    }
}
