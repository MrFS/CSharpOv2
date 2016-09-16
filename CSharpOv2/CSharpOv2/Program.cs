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
            Brok brok2 = new Brok(3);
            Brok brok3 = new Brok(brok2);

            Console.WriteLine("Den første brøken har verdi " + brok1.Teller + "/" + brok1.Nevner + "\n" +
                              "Brøkens sum er " + brok1.Verdi() + "\n" +
                              "Brøkens største felles faktor er " + brok1.FinnBCF() + "\n" + 
                              "Forkortet versjon av brøken: " + brok1.FinnForkortet() + "\n" +
                              "Hele brøk1 printet ut: " + brok1.ToString() + "\n" +
                              "--------------------------------------------------------------------------");

            Console.WriteLine("Den andre brøken har verdi " + brok2.Teller + "/" + brok2.Nevner + "\n" +
                              "Brøkens sum er " + brok2.Verdi() + "\n" +
                              "Brøkens største felles faktor er " + brok2.FinnBCF() + "\n" +
                              "Forkortet versjon av brøken: " + brok2.FinnForkortet() + "\n" +
                              "Hele brøk2 printet ut: " + brok2.ToString() + "\n" +
                              "--------------------------------------------------------------------------");

            Console.WriteLine("Den tredje brøken har verdi " + brok3.Teller + "/" + brok3.Nevner + "\n" +
                              "Brøkens sum er " + brok3.Verdi() + "\n" +
                              "Brøkens største felles faktor er " + brok3.FinnBCF() + "\n" +
                              "Forkortet versjon av brøken: " + brok3.FinnForkortet() + "\n" +
                              "Hele brøk3 printet ut: " + brok3.ToString() + "\n" +
                              "--------------------------------------------------------------------------");

            Console.WriteLine("Sum: " + brok1.Verdi());
            Console.WriteLine("Største Felles Faktor: " + brok1.FinnBCF());
            Console.WriteLine(brok1.FinnForkortet());
            Console.WriteLine("----------------");
            Console.WriteLine(brok2.Gange(brok1).Teller);
            Console.WriteLine(brok2.Gange(brok1).Nevner);
            Console.WriteLine(brok2.ToString());
            Console.ReadKey();

        }
    }
}
