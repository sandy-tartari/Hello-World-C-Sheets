using System;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            // Algoritmo 1 = leia o nome e escreva um comprimento (Hello) para este nome
            string nome;
            Console.WriteLine("digite o seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("Hello {0}!", nome);
        }
    }
}
