using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Conversoes_e_outros_tipos_numericos
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario;
            salario = 1200.50;

            int salarioEmInteiro;
            salarioEmInteiro = (int)salario; // forçar conversão de tipos
            Console.WriteLine(salarioEmInteiro);

            long idade; // int grandão, de 64bits
            idade = 1300000000000;

            short quantidadeDeProdutos; // int menorzinho, de 16bits
            quantidadeDeProdutos = 15000;

            float altura = 1.80f; // double com menor precisao


            Console.ReadLine();
        }
    }
}
