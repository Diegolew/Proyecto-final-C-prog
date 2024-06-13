// See https://aka.ms/new-console-template for more information
using System;

namespace CesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la frase:");
            string input = Console.ReadLine();

            Console.WriteLine("Ingrese el desplazamiento (1-9):");
            if (int.TryParse(Console.ReadLine(), out int shift) && shift >= 1 && shift <= 9)
            {
                Console.WriteLine("Seleccione una opción (1. Cifrar, 2. Descifrar):");
                string option = Console.ReadLine();

                if (option == "1")
                {
                    Console.WriteLine($"Frase cifrada: {Cipher.Encrypt(input, shift)}");
                }
                else if (option == "2")
                {
                    Console.WriteLine($"Frase descifrada: {Cipher.Decrypt(input, shift)}");
                }
                else
                {
                    Console.WriteLine("Opción no válida. Seleccione 1 para cifrar o 2 para descifrar.");
                }
            }
            else
            {
                Console.WriteLine("El desplazamiento debe ser un número entero entre 1 y 9.");
            }
        }
    }
}
