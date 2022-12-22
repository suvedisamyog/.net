using System;
namespace _2darray{
    internal class Program{
        static void Main(string[] args){
            int[,] ResultMatrix = new int[2, 2];
            int[,] Matrix1 = { { 1, 2 }, { 2, 3 } };
            int[,] Matrix2 = { { 3, 5 }, { 8, 9 } };
            Console.WriteLine("\nSum of Both the Matrics:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    ResultMatrix[i, j] = Matrix1[i, j] + Matrix2[i, j];
                    Console.Write($"{ResultMatrix[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
