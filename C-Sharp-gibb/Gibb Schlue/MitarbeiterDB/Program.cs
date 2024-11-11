// See https://aka.ms/new-console-template for more information


using System.Diagnostics.SymbolStore;
using System.Net.Mail;

internal class Program
{
    static List<Mitarbeiter> mitarbeiterListe = new List<Mitarbeiter>();
    static void Main(string[] args)
    { 
        int countOfMitarbeiter = 0;
        string action = Console.ReadLine("Was möchtest du machen?: s(search Mitarbeiter), c(create Mitarbeiter), ch(change user)").ToLower();
        if (action == "s")
        {
            
        }
        else if (action == "c")
        {
            createMitarbeiter();
            countOfMitarbeiter++;
        }
        
        else if (action == "ch")
        {
            changeuser(countOfMitarbeiter);
            
        }
        else
        {
            continue
        }
    }


    class Mitarbeiter
    {
        public string Name;
        public string Vorname;
        public int Alter;
        public int Gehalt;
        public string Funktion;

        public Mitarbeiter(string name, string vorname, int alter, int gehalt, string funktion)
        {
            Name = name;
            Vorname = vorname;
            Alter = alter;
            Gehalt = gehalt;
            Funktion = funktion;


        }


    }

    static void createMitarbeiter()
    {
        string Name = Console.ReadLine("Name");
        string Vorname = Console.ReadLine("Vorname");
        int Alter = Convert.ToInt32(Console.ReadLine("Alter"));
        int Gehalt = Convert.ToInt32(Console.ReadLine("Gehalt"));
        string Funktion = Console.ReadLine("Funktion");
        
        Mitarbeiter mitarbeiter1 = new Mitarbeiter(Name, Vorname, Alter, Gehalt, Funktion);
        mitarbeiterListe.Add(mitarbeiter);
    }

    static void changeuser();{
        if(Mitarbeiter1)
        
        }
    }
}
    