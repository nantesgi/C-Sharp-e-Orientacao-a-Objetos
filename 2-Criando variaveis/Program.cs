using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Criando_variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade; 
            idade = 15;

            Console.WriteLine(idade); //com \n

            idade = 10;

            Console.WriteLine("Sua idade é: " + idade);

            Console.Write("Execução finalizada. "); //sem o \n

            Console.WriteLine("Tecle enter para sair");

            Console.ReadLine();
        }
    }
}
