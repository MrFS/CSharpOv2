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

            Console.WriteLine(brok1.Verdi());
            Console.WriteLine(brok1.BCF(26,44));
            Console.WriteLine(brok1.Forkort(12, 8));
            Console.ReadKey();

        }
    }
}
