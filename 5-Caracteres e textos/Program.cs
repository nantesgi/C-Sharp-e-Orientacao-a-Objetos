using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Caracteres_e_textos
{
    class Program
    {
        static void Main(string[] args)
        {
            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)61;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Este é um texto de tipo String " + 2022;
            Console.WriteLine(titulo);

            string testandoQuebraDeLinhas = @"-.NET - Java
- JavaScript";
            Console.WriteLine(testandoQuebraDeLinhas);

            Console.WriteLine("Digite enter para sair");
            Console.ReadLine();
        }
    }
}
