using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOv2
{
    class Program
    {
        static void Main(string[] args)
        {

            Brok brok1 = new Brok(12, 8);

            Console.WriteLine("Sum: " + brok1.Verdi());
            Console.WriteLine("Største Felles Faktor: " + brok1.FinnBCF());
            Console.WriteLine(brok1.FinnForkortet());
            Console.ReadKey();

        }
    }
}
