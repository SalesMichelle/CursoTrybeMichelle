﻿// Imprimir o número até o que o usuário escolher

using System ;

    class Program 
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine()); // A variável numero é de acordo com que o usuário digitar.

            int i = 1 ; // Inicializa a variável i

            while (i <= numero )
            {
                Console.Write(i + " ") ; // Escreve na tela os número de 1 até o "numero"
                i++ ;
            }
        }
    }
