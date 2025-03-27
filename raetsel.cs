using System;

public class raetsel
{
    public static void r1()
    {
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
        }
        else
        {
            Console.WriteLine("Falsche Reihenfolge! Versuche es erneut.");
            r1();
        }

    }
    public static void r2()
    {

    }
    public static void r3()
    {

    }
    public static void r4()
    {

    }
}