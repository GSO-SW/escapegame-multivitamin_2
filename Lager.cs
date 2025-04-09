


  

using System;
using System.Linq;

public class Lager
{
    public int RaumNr;
    public bool CharakterAnw;
    public bool Access;
    public string[] Gegenstaende = new string[13];
    public int[] Zugaenge = new int[4];

    public static void Main()
    {
        Console.WriteLine("Willkommen in Lager 3, in diesem Lager sind 2 Codes versteckt. Suchen Sie nach Hinweisen.");
        
        RaetselSchalter();
        RaetselSchrank();
    }

    static void RaetselSchalter()
    {
        Console.WriteLine("Es gibt mehrere Schalter in diesem Raum. Finde die richtige Reihenfolge!");
        int[] richtigeReihenfolge = { 2, 4, 1, 3 };
        int[] eingabe = new int[4];

        for (int i = 0; i < 4; i++)
        {
            Console.Write("Schalter " + (i + 1) + ": ");
            eingabe[i] = int.Parse(Console.ReadLine());
        }

        if (eingabe.SequenceEqual(richtigeReihenfolge))
        {
            Console.WriteLine("Richtig! Du erhältst eine Nummer: 7");
        }
        else
        {
            Console.WriteLine("Falsche Reihenfolge! Versuche es erneut.");
            RaetselSchalter();
        }
    }

    static void RaetselSchrank()
    {
        Console.WriteLine("Der Schrank ist geschlossen. Löse das Buchstaben-Zahlen-Code-Rätsel!");
        Console.WriteLine("Hinweis: Welche Nummern haben die Buchstaben im Alphabet? (T = ?, L = ?, R = ?)");
        
        Console.Write("Gib die richtige Zahlenkombination ein: ");
        string eingabe = Console.ReadLine();

        if (eingabe == "201218")
        {
            Console.WriteLine("Richtig! Du erhältst eine Nummer: 3");
        }
        else
        {
            Console.WriteLine("Falsch! Versuche es erneut.");
            RaetselSchrank();
        }
    }
}
