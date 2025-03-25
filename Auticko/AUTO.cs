using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auticko
{
    internal class AUTO
    {
        private double palivo = 55;

        public void natankuj()
        {
            Console.WriteLine($"Natankoval si {55-palivo} paliva");
        }

        public void stav_paliva()
        {
            Console.WriteLine($"Aktuální stav paliva {palivo}");
        }

        public void jed()
        {
            int spotreba = 6;
            if (palivo == 0)
            {
                Console.WriteLine("Není palivo bro");
            }
            else
            {
                Console.WriteLine("Kolik km chces ujet?");
                double km = Convert.ToInt32(Console.ReadLine());
                double pouzite_palivo = (km / 100) * spotreba;
                pouzite_palivo = Math.Round(pouzite_palivo, 2);
                palivo -= pouzite_palivo;
                Console.WriteLine($"Ujel si {km} a spotřeboval si {pouzite_palivo} litru paliva");
            }
        }
    }
}
