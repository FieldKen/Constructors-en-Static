using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Fiets
    {
        //Niet uniek aan een object, maar over de hele klasse
        private static int aantal = 0;
        public Fiets()
        {
            aantal++;
            Console.WriteLine($"Er zijn {aantal} fietsen aangemaakt.");
        }

        public static void VerminderFiets()
        {
            aantal--;
            Console.WriteLine($"Er zijn {aantal} fietsen aangemaakt.");
        }

        public static void GeefAantal()
        {
            Console.WriteLine($"Er zijn {aantal} fietsen aangemaakt.");
        }
    }
}
