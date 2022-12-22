using System;
namespace first{
    public class example    {
        public static void myMethod()
        {
            Console.WriteLine("This is written inside namespace named first inside example class ");
        }
    }
}
namespace second{
    public class MyClass{
        public static void Main()
        {
            first.example.myMethod();
        }
    }
}