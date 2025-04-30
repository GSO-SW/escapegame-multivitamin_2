using System;
using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;

public class raetsel
{
    public static void r1()
    {
        int counter=0;
        bool result = false;
        Console.WriteLine("Wilkommen im ersten Lager, hier ist die erste Zahl versteckt für den Freezer, bitte löse, das erste Rätsel ");
        Console.WriteLine("");
        Console.WriteLine("Es gibt mehrere Schalter in diesem Raum. Finde die richtige Reihenfolge!");
        Console.WriteLine("ihr habt die Zahlen 1,2,3,4 zur Verfügung. Pro schalter eine Zahl.");
        int[] richtigeReihenfolge = { 2, 4, 1, 3 };
        //hier wurde ein array mit der größe 4 und eine reihenfolge bestimmt und ein counter auf 3 gesetzt damit es 3 mal wiederholt wird
        //AUßerdem wir ein Array richtige reihnfolge gennant
        int[] eingabe = new int[4];
        while(counter < 3)
        {
             for (int i = 0; i < 4; i++)
        {
            Console.Write("Schalter " + (i + 1) + ": ");

            try
            {
                eingabe[i] = int.Parse(Console.ReadLine());
                 // int parse dient dafür das man werte in bestimmte daten type convertieren kann so wie convert to double....
            }
            catch (Exception)
            {
                Console.WriteLine("Zahl ungültg");
                r1();
            }
                       
        }

        if (eingabe.SequenceEqual(richtigeReihenfolge))
        {
            Console.WriteLine("Richtig! Du erhältst eine Nummer: 7");
            result = true;
            Start.start_mth();
        }  //Wenn man richtig ist wird man weitergeleitet wen nicht erhöht sich der counter wenn 3 mal gameover
        else
        {
            Console.WriteLine("Falsche Reihenfolge! Versuche es erneut.");
            result = false;
            counter++; // Bei falscher Antwort: Fehlerzähler erhöhen

        }
     
        }
        raetsel.gameover();


    }
    public static void r2()
    {
        int counter=0;// Zählt Fehlversuche
        // Begrüßung und Hinweise
        Console.WriteLine("Wilkommen im zweiten Lager, hier ist die zweite Zahl versteckt für den Freezer, bitte löse, das zweite Rätsel ");
        Console.WriteLine("");

        Console.WriteLine("Der Schrank ist geschlossen. Löse das Buchstaben-Zahlen-Code-Rätsel!");
        Console.WriteLine("Hinweis: Welche Nummern haben die Buchstaben im Alphabet? (T = ?, L = ?, R = ?)");
         // Erste Eingabeaufforderung       
        Console.Write("Gib die richtige Zahlenkombination ein: ");
        int eingabe=0;
        try
        {
            eingabe = int.Parse(Console.ReadLine());// Versuche, Eingabe als Zahl zu parsen

        }
        catch (Exception)
        {
            Console.WriteLine("Zahl ungültig");
            r2();
        }
      
      
        Console.WriteLine("");
        while(counter < 3)// Schleife für Fehlversuche
        {
      
            if (eingabe == 201218)
            {
                Console.WriteLine("Richtig! Du erhältst eine Nummer: 3");
                Console.WriteLine("");
                    
                Start.start_mth();
            }
            else
            {
                Console.WriteLine("Falsch! Versuche es erneut.");
                counter++;// Fehlerzähler erhöhen
            }

        }
        raetsel.gameover();
       
    }
      
    public static void r3()
    {
        int counter=0;  //Zählt, wie oft eine falsche Antwort gegeben wurde
        int zähler = 0; // Zählt, wie oft insgesamt versucht wurde (nicht nur falsch)

        while(counter<3) // Schleife läuft, solange weniger als 3 falsche Versuche passiert sind
        {
        do
        {   // Begrüßungstext und Erklärung des Rätsels
            Console.WriteLine("Wilkommen im dritten Lager, hier ist die dritte Zahl versteckt für den Freezer, bitte löse, das dritte Rätsel ");
            Console.WriteLine("");

            Console.WriteLine("Der Schrank ist geschlossen. Löse das folgende Rätsel.");
            Console.WriteLine("Wer hört alles und sagt nichts?");
            
            Console.Write("Gib die richtige Antwort ein: ");
            string eingabe = Console.ReadLine();
             // Überprüfen, ob die Antwort korrekt ist
            if (eingabe == "das Ohr")
            {
                Console.WriteLine("Richtig! Du erhältst eine Nummer: 6");
                Console.WriteLine("");
                Start.start_mth();// Falls richtig: Start einer anderen Methode
            }
            else
            {
                Console.WriteLine("Falsch! Versuche es erneut.");
                Console.WriteLine("");
                counter++;// Bei falscher Antwort: Fehlerzähler erhöhen
            }
                zähler++; // Jeder Versuch zählt, egal ob richtig oder falsch


        } while (zähler < 3);// Nach 3 Versuchen (insgesamt) wird die Schleife verlassen
        }
        raetsel.gameover();// Nach zu vielen Fehlversuchen: Game Over oder Abbruch
  
    }
    public static void r4()
    {
        int counter = 0;//Zählt, wie oft eine falsche Antwort gegeben wurde
        while(counter<3)// Zählt, wie oft insgesamt versucht wurde (nicht nur falsch)
        {
            int zähler = 0;
            do
            {         // Begrüßungstext und Erklärung des Rätsels
                Console.WriteLine("Wilkommen im vierten Lager, hier ist die zweite Zahl versteckt für den Freezer, bitte löse, das vierte Rätsel ");
                Console.WriteLine("");

                Console.WriteLine("Der Schrank ist geschlossen. Löse das folgende Wörter-Rätsel!");
                Console.WriteLine("utkilutilm"); 
                
                Console.Write("Gib das gesuchte Wort ein ein: ");
                string eingabe = Console.ReadLine();//eingabe des benutzers

                if (eingabe == "multikulti") //wen die eingabe des benutzers richtig ist kriegt man den code 8
                {
                    Console.WriteLine("Richtig! Du erhältst eine Nummer: 8");
                    Console.WriteLine("");
                    Start.start_mth(); // Falls richtig: Start einer anderen Methode
                }
                else
                {
                    Console.WriteLine("Falsch! Versuche es erneut.");
                    counter++;// Bei falscher Antwort: Fehlerzähler erhöhen
                }      
                
                zähler++;

            }while (zähler < 3);
        }    //zähler wird mit jeden versuch um 1 erhöht bis 3 dan gameover
        raetsel.gameover();
        
    }
    public static void r5()
    {
        int counter = 0;//Zählt, wie oft eine falsche Antwort gegeben wurde
        while(counter < 3)// Maximal 3 Versuche erlaubt
        {
            {   // Einleitungstext
                bool result = false;
                Console.WriteLine("Wilkommen zum Freezer");
                // Die richtige Reihenfolge der Zahlen
                Console.WriteLine("Ihr Ziel ist es alle Codes die sie Von den voherigen Räumen gesammelt haben in die richtige reihenfollge im schloss von dem freezer einzugeben");
                int[] richtigeReihenfolge = { 7, 3, 6, 8, };
                int[] eingabe = new int[4];// Array zum Speichern der Benutzereingabe
                
                for (int i = 0; i < 4; i++)// Schleife für 4 Zahleneingaben
                
                {

                
                try
                {
                  eingabe[i] = int.Parse(Console.ReadLine());  // Benutzereingabe in Integer umwandeln
                }
                catch (Exception)
                {
                    Console.WriteLine("Zahl ungültig");
                    // Rekursiver Aufruf bei ungültiger Eingabe ist riskant!
                     // Besser: Schleife einfach wiederholen, nicht Methode neu aufrufen
                    r5();
                }
                {
                Console.Write("Freezer " + (i + 1) + ": ");
                //(i + 1): Erhöht den Wert der Variable i um 1.
                }
                
                }
                // Prüfen, ob die Eingabe korrekt ist
                if (eingabe.SequenceEqual(richtigeReihenfolge))
                {
                Console.WriteLine("Richtig! ");
                result = true;
                }
                else
                {
                Console.WriteLine("Falsche Reihenfolge! Versuche es erneut.");
                counter++;// Fehlerzähler erhöhen
                result = false;
                }
                Console.WriteLine("");// Leerzeile für bessere Lesbarkeit

                Console.WriteLine("╔══════════════════════════════════════════════╗");
                Console.WriteLine("║                                              ║");
                Console.WriteLine("║  Herzlichen Glückwunsch, du hast Feierabend! ║");
                Console.WriteLine("║                                              ║");
                Console.WriteLine("╚══════════════════════════════════════════════╝");

                menue.menue_anzeigen();
            }  
            raetsel.gameover();

        }
       
    }
    public static void gameover()
    {
       
        Console.WriteLine("╔══════════════════════════╗");
        Console.WriteLine("║                          ║");
        Console.WriteLine("║    G A M E   O V E R     ║");
        Console.WriteLine("║                          ║");
        Console.WriteLine("╚══════════════════════════╝");

        menue.menue_anzeigen();
        
        
    }
}