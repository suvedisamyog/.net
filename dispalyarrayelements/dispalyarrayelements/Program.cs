using System;
namespace dispalyarrayelements{
    internal class Program{
        static void Main(string[] args){
            int[,] Array1 = new int[3, 3];
            int[,] Array2 = new int[2, 2];

            Console.WriteLine("Enter elements for array 1");
            for(int i = 0; i < 3; i++) {
                for(int j= 0; j < 3; j++){
                    Array1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Elements of array 1 are:");
            foreach(int i in Array1)
            {
                Console.Write($"{i}\t");
            }
           
        }
    }
}
