using System;
using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;

public class raetsel// alle Reatsel erstellt die 
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
            }
                       //Notiz sachen die ich bei einem code nicht kommentiert habe wurden bei anderen codes kommentiert da sie fast identisch sind
        }

        if (eingabe.SequenceEqual(richtigeReihenfolge))
        {
            Console.WriteLine("Richtig! Du erhältst eine Nummer: 7");
            result = true;
            Start.start_mth();
            break;
        }  //Wenn man richtig ist wird man weitergeleitet wen nicht erhöht sich der counter wenn 3 mal gameover
        else
        {
            Console.WriteLine("Falsche Reihenfolge! Versuche es erneut.");
            result = false;
            counter++;

        }
     
        }
        raetsel.gameover();


    }
    public static void r2()
    {
        int counter=0;
        Console.WriteLine("Wilkommen im zweiten Lager, hier ist die zweite Zahl versteckt für den Freezer, bitte löse, das zweite Rätsel ");
        Console.WriteLine("");

        Console.WriteLine("Der Schrank ist geschlossen. Löse das Buchstaben-Zahlen-Code-Rätsel!");
        Console.WriteLine("Hinweis: Welche Nummern haben die Buchstaben im Alphabet? (T = ?, L = ?, R = ?)");
                
        Console.Write("Gib die richtige Zahlenkombination ein: ");
        int eingabe=0;
    
        Console.WriteLine("");
        while(counter < 3)
       
        {
             try
        {
            eingabe = int.Parse(Console.ReadLine());//ist einfach das gleiche wie oben

        }
        catch (Exception)
        {
            Console.WriteLine("Zahl ungültig");
            
        }
      
            if (eingabe == 201218)
            {
                Console.WriteLine("Richtig! Du erhältst eine Nummer: 3");
                Console.WriteLine("");
                    
                Start.start_mth();
            }
            else
            {
                Console.WriteLine("Falsch! Versuche es erneut.");
                counter++;
            }

        }
        raetsel.gameover();
       
    }
      
    public static void r3()
    {
        int counter=0;
        int zähler = 0;
        while(counter<3)
        {
        do
        {
            Console.WriteLine("Wilkommen im dritten Lager, hier ist die dritte Zahl versteckt für den Freezer, bitte löse, das dritte Rätsel ");
            Console.WriteLine("");

            Console.WriteLine("Der Schrank ist geschlossen. Löse das folgende Rätsel.");
            Console.WriteLine("Wer hört alles und sagt nichts?");
            
            Console.Write("Gib die richtige Antwort ein: ");
            string eingabe = Console.ReadLine();

            if (eingabe == "das Ohr")
            {
                Console.WriteLine("Richtig! Du erhältst eine Nummer: 6");
                Console.WriteLine("");
                Start.start_mth();
            }
            else
            {
                Console.WriteLine("Falsch! Versuche es erneut.");
                Console.WriteLine("");
                counter++;
            }
                zähler++;

        } while (zähler < 3);
        }
        raetsel.gameover();
  
    }
    public static void r4()
    {
        int counter = 0;
        while(counter<3)
        {
            int zähler = 0;
            do
            {
                Console.WriteLine("Wilkommen im vierten Lager, hier ist die zweite Zahl versteckt für den Freezer, bitte löse, das vierte Rätsel ");
                Console.WriteLine("");

                Console.WriteLine("Der Schrank ist geschlossen. Löse das folgende Wörter-Rätsel!");
                Console.WriteLine("utkilutilm"); 
                
                Console.Write("Gib das gesuchte Wort ein ein: ");
                string eingabe = Console.ReadLine();

                if (eingabe == "multikulti") //wen die eingabe des benutzers richtig ist kriegt man den code 8
                {
                    Console.WriteLine("Richtig! Du erhältst eine Nummer: 8");
                    Console.WriteLine("");
                    Start.start_mth();
                }
                else
                {
                    Console.WriteLine("Falsch! Versuche es erneut.");
                    counter++;
                }      
                
                zähler++;

            }while (zähler < 3);
        }    //zähler wird mit jeden versuch um 1 erhöht bis 3 dan gameover
        raetsel.gameover();
        
    }
    public static void r5()
    {
        int counter = 0;
        while(counter < 3)
        {
            
                bool result = false;
                Console.WriteLine("Wilkommen zum Freezer");
                Console.WriteLine("Ihr Ziel ist es alle Codes die sie Von den voherigen Räumen gesammelt haben in die richtige reihenfollge im schloss von dem freezer einzugeben");
                int[] richtigeReihenfolge = { 7, 3, 6, 8, };
                int[] eingabe = new int[4];

                for (int i = 0; i < 4; i++)
                //eine for schleife die sich 4 mal wiederholt
                {
                {
                Console.Write("Freezer " + (i + 1) + ": ");
                }
               

                
                try
                {
                  eingabe[i] = int.Parse(Console.ReadLine());  
                }
                catch (Exception)
                {
                    Console.WriteLine("Zahl ungültig");

                }
            
                }

                if (eingabe.SequenceEqual(richtigeReihenfolge))
                {
                 result = true;
                    
                Console.WriteLine("Richtig! ");
               
                Console.WriteLine("╔══════════════════════════════════════════════╗");
                Console.WriteLine("║                                              ║");
                Console.WriteLine("║  Herzlichen Glückwunsch, du hast Feierabend! ║");
                Console.WriteLine("║                                              ║");
                Console.WriteLine("╚══════════════════════════════════════════════╝");
                menue.menue_anzeigen();
                break; 
                }
                else
                {
                Console.WriteLine("Falsche Reihenfolge! Versuche es erneut.");
                counter++;
                result = false;
                }
                Console.WriteLine("");
                raetsel.gameover();
                break;

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