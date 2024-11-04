using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie heisst du ?");
            string name = Console.ReadLine();
            Console.WriteLine("Ihr name lautet" + name);
            Console.WriteLine("Gib eine Kommazahl");
            float kommazahl = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Ihre Kommazahl lautet" + (kommazahl * 1000));
            Console.WriteLine("Gib eine gerade Zahl");
            int zahl = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ihre Komma Zahl: " + (zahl * zahl));

        }
    }
}
