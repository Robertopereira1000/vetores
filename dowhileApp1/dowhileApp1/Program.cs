using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dowhileApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 5;

            do

            {
                Console.WriteLine("Roberto Miguel");
                cont++;
            }
            while (cont < 5);
            {
                Console.WriteLine(cont++);
            }
        }
    }
}
