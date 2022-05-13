using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Criando_variaveis_flutuantes
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario;
            salario = 1200.70;

            Console.WriteLine(salario);

            double idade;

            idade = 15 / 2;
            Console.WriteLine(idade); // imprime um inteiro, porque a divisão envolve dois inteiros

            idade = 15.0 / 2;
            Console.WriteLine(idade); // devolve double, porque tem pelo menos um double envolvido

            Console.WriteLine("A execução acabou. Tecle enter para sair");
            Console.ReadLine();
        }
    }
}
