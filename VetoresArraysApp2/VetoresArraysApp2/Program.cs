using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetoresArraysApp2
{
    internal class Program
    {
        static void Main(string[] args)
          /*nomes e posições ex:1° nome (roberto  = [0]  , Valdirene =  [1], Miguel = [2],
         * maria = [3] , Aparecido = [4] , Sverina = [5]  Jonas [6].sempre começara da posição 0 .
          */
        { 
        
            string[] nomes = { "roberto", "Valdirene ", "Miguel", "maria", "aparecido", "Severina", "Jonas" };
            Console.WriteLine(nomes[5]);
        }
      
    }
}
