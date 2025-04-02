using System;
using System.Security.Cryptography.X509Certificates;

public class raetsel
{
    public static void r1()
    {
        bool result = false;
        Console.WriteLine("Wilkommen im ersten Lager, hier ist die erste Zahl versteckt für den Freezer, bitte löse, das erste Rätsel ");
        Console.WriteLine("");
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
            result = true;
        }
        else
        {
            Console.WriteLine("Falsche Reihenfolge! Versuche es erneut.");
            r1();
            result = false;
        }
       

    }
    public static void r2()
    {
        Console.WriteLine("Wilkommen im zweiten Lager, hier ist die zweite Zahl versteckt für den Freezer, bitte löse, das erste Rätsel ");
        Console.WriteLine("");

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
            r2();
        }

    }
      
    public static void r3()
    {

    }
    public static void r4()
    {

    }
    public static void r5()
    {

        RaetselFreezer();

static void RaetselFreezer()
{
    bool result = false;
    Console.WriteLine("Wilkommen zum Freezer");
    Console.WriteLine("Ihr Ziel ist es alle Codes die sie Von den voherigen Räumen gesammelt haben in die richtige reihenfollge im schloss von dem freezer einzugeben");
    int[] richtigeReihenfolge = { 7, 3, 6, 8, };
    int[] eingabe = new int[4];
    for (int i = 0; i < 4; i++);
    for (int i = 0; i < 4; i++)
    {
    Console.Write("Freezer " + (i + 1) + ": ");
    eingabe[i] = int.Parse(Console.ReadLine());
    }

    if (eingabe.SequenceEqual(richtigeReihenfolge))
     {
     Console.WriteLine("Richtig! ");
     result = true;
     }
    else
    {
    Console.WriteLine("Falsche Reihenfolge! Versuche es erneut.");
    r1();
    result = false;
    }




}
        
    }
}