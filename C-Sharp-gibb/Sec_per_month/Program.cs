using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sec_per_month
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int SecPerDay = 86400;
            Console.WriteLine("Wie viele Tage hat der Monat von dem du die Sekunden ausrechnen willst? 28,30, 31");
            int days = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dein Monat hat " + (days * SecPerDay) + "Sekunden");
            Console.ReadLine();

        }
    }
}
