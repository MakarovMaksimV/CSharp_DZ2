using System.Text;

namespace DZ2;

class Program
{
    static void Main(string[] args)
    {
        int[,] a = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };
        int[] b = new int [a.Length];
        int k = 0;

        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                b[k] = a[i, j];
                k++;
            }
        }


        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                a[i, j] = b.Min();
                b[Array.IndexOf(b,b.Min())] = b.Max();
            }
        }


        for(int i = 0; i<a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(0); j++)
            {
                Console.Write(a[i,j] + " ");
            }
            Console.WriteLine();

        }
        Console.ReadKey();
    }


}

