using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temAestagio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a palavra");
            string palavra = Console.ReadLine();
            int temA = 0;
            for(int ii = 0; ii < palavra.Length; ii++)
            {
               temA += ((palavra[ii] == 'a') || (palavra[ii] == 'A'))?1: 0;
            }
            if (temA == 0)
            {
                Console.WriteLine($"{palavra} nao contem a");
            }
            else
            {
                Console.WriteLine($"A palavra possui {temA} letra(s) a");
            }
            Console.ReadKey();
        }
    }
}
