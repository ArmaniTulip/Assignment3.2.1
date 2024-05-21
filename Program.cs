using System.Numerics;

namespace Assignment3._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] assignmentMatrix = { { 1, 2, 3 }, { 4, 5, 6 } };

            for (int i = 0; i < assignmentMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < assignmentMatrix.GetLength(1); j++)
                {
                    Console.Write("|");
                    Console.Write($"{assignmentMatrix[i, j]} ");
                }
                Console.WriteLine("|");
                Console.WriteLine();
            }
            
        }
        
    }
}
