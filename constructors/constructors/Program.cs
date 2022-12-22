using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructure
{
    internal class Program
    {
        private string name = "";
        public Program()
        {
            Console.WriteLine("i am a default constructure");
        }

        public Program(string name)
        {
            Console.WriteLine("i am a paratarimized constructer");
            Console.WriteLine("name:" + name + "\n");
        }
        public Program(Program p)
        {
            Console.WriteLine(p.name);
        }
        static Program()
        {
            Console.WriteLine("i am a stsatic constructor");
        }

        static void Main(string[] args)
        {
            Program p1 = new Program();
            Program p3 = new Program();

            Console.ReadKey();
        }
    }
}
