using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número do dia da semana (1-7):");
            int dayOfWeek = Convert.ToInt32(Console.ReadLine());

            string dayName;

            switch (dayOfWeek)
            {
                case 1:
                    dayName = "Domingo";
                    break;
                case 2:
                    dayName = "Segunda-feira";
                    break;
                case 3:
                    dayName = "Terça-feira";
                    break;
                case 4:
                    dayName = "Quarta-feira";
                    break;
                case 5:
                    dayName = "Quinta-feira";
                    break;
                case 6:
                    dayName = "Sexta-feira";
                    break;
                case 7:
                    dayName = "Sábado";
                    break;
                default:
                    dayName = "Dia inválido";
                    break;
            }

            Console.WriteLine($"O dia da semana é: {dayName}");
        }



    }
        
    }
    

