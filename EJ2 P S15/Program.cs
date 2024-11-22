using System;

namespace EJ2_P_S15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random Aleatorio = new Random();
            Console.Write("Ingrese # de matriz -> "); int M = int.Parse(Console.ReadLine());Console.WriteLine("\nMatriz original: \n");
            int[,] Matriz = new int[M,M];
            int[,] Trans = new int[M, M];
            for (int i = 0; i < Matriz.GetLength(0); i++)//el "GetLength(0)" para buscar en las filas
            {
                for (int j = 0; j < Matriz.GetLength(1); j++)//El "GetLenght(1)" para buscar en las columnas
                {
                    Matriz[i, j] = Aleatorio.Next(40, 51);
                    Console.Write(Matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.Write("\nMatriz");Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(" trans");Console.ResetColor();Console.Write(":\n");
            for (int i = 0; i < Matriz.GetLength(0); i++)//el "GetLength(0)" para buscar en las filas
            {
                for (int j = 0; j < Matriz.GetLength(1); j++)//El "GetLenght(1)" para buscar en las columnas
                {
                    Trans[j, i] = Matriz[i, j];
                }
            }
            for (int i = 0; i < Matriz.GetLength(0); i++)//el "GetLength(0)" para buscar en las filas
            {
                for (int j = 0; j < Matriz.GetLength(1); j++)//El "GetLenght(1)" para buscar en las columnas
                {
                    Matriz[i, j] = Aleatorio.Next(40, 51);
                    Console.Write(Matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
                Console.ReadLine();
        }
    }
}
