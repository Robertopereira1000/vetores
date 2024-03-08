using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meu_primeiro_jogo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double n1, n2 ,resultado ;
            string avaliacao = "";

            Console.WriteLine("digite a nota 1 do aluno !:");
            n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("digite a nota 2 do aluno:!");
            n2 = double.Parse(Console.ReadLine());

            resultado = (n1 + n2) / 2;
            

            if (resultado >= 6 ) 
            {
                avaliacao = (" parabens voce passou!");
            }else if (resultado >= 5) 
            {
                avaliacao = "você está de recuperacao!";
            }else
            {
                avaliacao = ("\nvoce está reprovado");
            }
              Console.WriteLine("A média do aluno é :"  + resultado + " " + avaliacao);



        }
    }
}
