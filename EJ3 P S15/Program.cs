using System.Threading.Tasks;

namespace EJ3_P_S15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random Aleatorio = new Random();
            Console.Write("Ingrese # de filas -> "); int F = int.Parse(Console.ReadLine());
            Console.Write("Ingrese # de columnas -> "); int C = int.Parse(Console.ReadLine());
            int[,] Matriz = new int[F, C];
            int[] Suma = new int[C];
            for (int i = 0; i < Matriz.GetLength(0); i++)//el "GetLength(0)" para buscar en las filas
            {
                for (int j = 0; j < Matriz.GetLength(1); j++)//El "GetLenght(1)" para buscar en las columnas
                {
                    Matriz[i, j] = Aleatorio.Next(20, 31);
                    Suma[j] += Matriz[i, j];
                    Console.Write(Matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
            for (int i = 0;i < C;i++) { Console.ForegroundColor = ConsoleColor.Red; Console.Write(Suma[i] + "\t"); Console.ResetColor();}

                Console.WriteLine();
        }
    }
}
