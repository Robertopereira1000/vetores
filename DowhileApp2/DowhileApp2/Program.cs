using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DowhileApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
          
            do 
            {
                Console.WriteLine("Roberto MIguel");
                cont++;
            } 
            while (cont < 5);

            Console.WriteLine(cont );
        }
    }
}
