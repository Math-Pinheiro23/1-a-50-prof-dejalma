using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_a_50_prof_dejalma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aluno: Matheus Cardoso Pinheiro
            //R.A: 6322095
            //Curso: Análise e Desenvolvimento de Sistemas.
            //Semestre: 1°

            Console.WriteLine("Contador do 1 ao 50");

            int num1, num2;

            num1 = 1;
            num2 = 50;

            for (; num1 <= num2; num1++)
            {
                Console.WriteLine(num1);
            }

            Console.ReadKey();
        }
    }
}
