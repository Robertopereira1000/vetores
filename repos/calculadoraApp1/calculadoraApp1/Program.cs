using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadoraApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("qual operação deseja fazer");
            Console.WriteLine("1- adição");
            Console.WriteLine("2- subtração");
            Console.WriteLine("3- multiplicação");
            Console.WriteLine("4- divisão \n");

           

            int operacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro numero:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero:");
            int num2 = int.Parse(Console.ReadLine());

            int resultado = 0;

            switch (operacao)
            {
                case 1:
                    {
                        resultado = adicao(num1, num2);
                        break;
                    }
                case 2:
                    {
                        resultado = subtracao(num1, num2);
                        break;
                    }

                case 3:
                    {
                        resultado = multiplicacao(num1, num2);
                        break;
                    }
                case 4:
                    {
                        resultado = divisao(num1, num2);
                        break;
                    }
                default:
                    Console.WriteLine("numero invalidodigite um outro numero");
                    break;
            }
            Console.WriteLine("o resultado da operação com os numeros {0} e {1} è:{2}", num1, num2, resultado);
            Console.ReadLine() ;
        }




        public static int adicao(int num1, int num2)
        {
            int resultado = num1 + num2;
            return resultado;
        }
        public static int subtracao(int num1, int num2)
        {
            int resultado = num1 - num2;
            return resultado;
        }
        public static int multiplicacao(int num1, int num2)
        {
            int resultado = num1 * num2;
            return resultado;
        }
        public static int divisao(int num1, int num2)
        {
            int resultado = num1 / num2;
            return resultado;
        }
    }
    }
