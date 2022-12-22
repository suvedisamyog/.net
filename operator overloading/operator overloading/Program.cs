using System;
namespace OperatorOverloading
{
    class Example
    {
        public int val1, val2;
        public Example(int no1, int no2) {
            val1 = no1;
            val2 = no2;
        }
        public Example() { }

        public static Example operator -(Example eg1){
            eg1.val1 = -eg1.val1;
            eg1.val1 = -eg1.val1;
            return eg1;
        }
        public void Print(){
            Console.WriteLine("value1 =" + val1);
            Console.WriteLine("value2 =" + val2);
            Console.Read();
        }
        class Program{
            static void Main(string[] args)          {
                Example eg = new Example(30, -60);
                eg.Print();
                Example eg1 = new Example();
                eg1 = -eg;
                eg1.Print();
                Console.Read();
            }
        }
    }
}