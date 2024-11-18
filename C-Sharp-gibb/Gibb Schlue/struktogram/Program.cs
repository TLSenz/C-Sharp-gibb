internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Gib ersten String: ");
        string first_string = Console.ReadLine();
        Console.WriteLine("Gib zweiten String: ");
        string second_string = Console.ReadLine();

        Console.WriteLine(quersumme(first_string, second_string));





    }

    public static int quersumme(string first_string, string second_string)
    {
        int summe = 0;

        char[] charArr = (first_string + second_string).ToCharArray();
        Console.WriteLine(charArr);
        Console.WriteLine(charArr[1]);
            

        for(var i = 0 ; i < charArr.Length; i++)
        {
            if(Char.IsDigit(charArr[i]) == true)
            {
                summe += charArr[i] - '0';
            }
            else
            {
                continue;
            }
        }

        return summe;
    }
}