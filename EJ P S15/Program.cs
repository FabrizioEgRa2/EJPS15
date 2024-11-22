using System;

namespace EJ_P_S15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random Aleatorio = new Random();
            Console.Write("Ingrese # de filas -> ");int F=int.Parse(Console.ReadLine());
            Console.Write("Ingrese # de columnas -> ");int C=int.Parse(Console.ReadLine());
            
            //FILAS |
            //COLUMNAS <-->

            int[,] Matriz=new int[F,C]; // es lo mismo que int [][] Matriz = new int [][];
            for (int i = 0; i < Matriz.GetLength(0); i++)//el "GetLength(0)" para buscar en las filas
            {
                for (int j = 0; j < Matriz.GetLength(1); j++)//El "GetLenght(1)" para buscar en las columnas
                {
                    Matriz[i, j] = Aleatorio.Next(30, 51);
                    Console.Write(Matriz[i, j]+"\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
