// See https://aka.ms/new-console-template for more information
using System;

namespace CesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la frase a cifrar:");
            string input = Console.ReadLine();

            Console.WriteLine("Ingrese el desplazamiento:");
            if (int.TryParse(Console.ReadLine(), out int shift))
            {
                string encrypted = Cipher.Encrypt(input, shift);
                Console.WriteLine($"Frase cifrada: {encrypted}");

                string decrypted = Cipher.Decrypt(encrypted, shift);
                Console.WriteLine($"Frase descifrada: {decrypted}");
            }
            else
            {
                Console.WriteLine("El desplazamiento debe ser un número entero.");
            }
        }
    }
}
