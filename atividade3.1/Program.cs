using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace atividade3._1
{
    class Program
    {
        static void Main(string[] args)
        {


            double IMC, altura, peso;
            Console.WriteLine("Digite sua altura?");
            peso = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu peso?");
            altura = Double.Parse(Console.ReadLine());
            IMC = peso / altura;
            Console.WriteLine(" índice é: " + IMC);



        }
    }
}
