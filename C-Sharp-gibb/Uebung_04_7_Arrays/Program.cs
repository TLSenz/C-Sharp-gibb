using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung_04_7_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int biggest = 0;
            int placeholder = 0;
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine((i + 1) + ". Zahl");
                placeholder = Convert.ToInt32(Console.ReadLine());
                if (placeholder > biggest)
                {
                    biggest = placeholder;
                }
                else
                {
                    continue;
                }

            }
            Console.WriteLine("Die grösste Zahl: "+biggest);
            Console.ReadLine();
                    

        }
    }
}
