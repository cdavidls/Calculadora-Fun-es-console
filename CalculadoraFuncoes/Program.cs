using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraFuncoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Valor 1: ");
            double v1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Valor 2: ");
            double v2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("[+] SOMA | [-] SUBTRAÇÃO | [*] MULTIPLICAÇÃO | [/] DIVISÃO");
            string operador = Console.ReadLine();

            switch (operador)
            {
                case "+":
                    Console.WriteLine(Somar(v1,v2));
                    break;
                case "*":
                    Console.WriteLine(Multiplicar(v1, v2));
                    break;
                case "-":
                    Console.WriteLine(Subtrair(v1, v2));
                    break;
                case "/":
                    Console.WriteLine(Dividir(v1, v2));
                    break;
                default:
                    Console.WriteLine("Opção Inválida!");
                    break;
            }

            Console.ReadKey();

        }

        static double Somar(double a, double b)
        {
            return a + b;
        }

        static double Subtrair(double a, double b)
        {
            return a - b;
        }

        static double Multiplicar(double a, double b)
        {
            return a * b;
        }

        static double Dividir(double a, double b)
        {
            return a / b;
        }



    }
}
