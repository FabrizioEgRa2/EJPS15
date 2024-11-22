using System;
using System.ComponentModel.Design;

namespace EJ4_P_S15
{
    internal class Program
    {
        public static void Menu()
        {
            Console.WriteLine();
            Console.WriteLine("Bienvenidos al sistema de registro de productos:\n");
            Console.WriteLine("1.- Registrar Productos\n2.- Mostrar Productos\n3.- Modificar Producto\n0.- SALIR\n");
            Console.Write("Seleccione una opción -> ");
        }
        static void Main(string[] args)
        {
            byte OCP;
            Menu();
            while (!byte.TryParse(Console.ReadKey(true).KeyChar.ToString(), out OCP)) { }
            Console.ReadKey();
        }
    }
}
