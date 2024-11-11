// See https://aka.ms/new-console-template for more information


using System.Diagnostics.SymbolStore;
using System.Net.Mail;

internal class Program
{
    static List<Mitarbeiter> mitarbeiterListe = new List<Mitarbeiter>();

    static void Main(string[] args)
    {
        string action = "";
        while (action != "exit")
        {



            Console.WriteLine("Was möchtest du machen?: s(search Mitarbeiter), c(create Mitarbeiter), ch(change user)");
            action = Console.ReadLine().ToLower();
            if (action == "s")
            {
                searchuser();
            }
            else if (action == "c")
            {
                createMitarbeiter();

            }

            else if (action == "ch")
            {
                changeuser(searchuser());

            }
            else
            {
                Console.WriteLine("Unkown action");
            }
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
        Console.WriteLine("Name:");
        string name = Console.ReadLine();
        
        Console.WriteLine("Vorname:");
        string vorname = Console.ReadLine();
        
        Console.WriteLine("Alter:");
        int alter = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Gehalt:");
        int gehalt = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Funktion:");
        string funktion = Console.ReadLine();

        Mitarbeiter mitarbeiter = new Mitarbeiter(name, vorname, alter, gehalt, funktion);
        mitarbeiterListe.Add(mitarbeiter);

        Console.WriteLine("Mitarbeiter erstellt.");
    }

    static Mitarbeiter searchuser(){
        Console.WriteLine("Welchen Namen suchst du ");
        string NameToSearch = Console.ReadLine();
        
        var foundMitarbeiter = mitarbeiterListe.Find(m => m.Name.ToLower() == NameToSearch.ToLower());
        if (foundMitarbeiter != null)
        {
            Console.WriteLine($"Der gesuchte Mitarbeiter heisst {foundMitarbeiter.Name}");
            return foundMitarbeiter;
        }
        else
        {
            
            Console.WriteLine("Gesuchter Mitarbeiter existiert nicht");
            return null;
        }
        
    }
    static void changeuser(Mitarbeiter userToChange)
        {
            Console.WriteLine("Neuer Namen");
                
            userToChange.Name = Console.ReadLine();
            Console.WriteLine("Neuer Vornamen");
            userToChange.Vorname = Console.ReadLine();
            Console.WriteLine("Neues Alter");
            userToChange.Alter = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Neues Gehalt");
            userToChange.Gehalt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Neue Funktion");
            userToChange.Funktion = Console.ReadLine();
            
            Console.WriteLine("Daten wurden aktualisiert");
        }
}
    