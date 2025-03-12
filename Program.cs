// See https://aka.ms/new-console-template for more information
Lager Lager1=new Lager();
Lager1.RaumNr=1;
Lager1.CharakterAnw=true;
Lager1.Access =true;
Lager1.Gegenstaende[0]="Schrank";
Lager1.Gegenstaende[1]="Schlüssel";
Lager1.Zugaenge[0] =4;

Lager Lager2=new Lager();
Lager2.RaumNr=2;
Lager2.CharakterAnw=false;
Lager2.Access =false;;
Lager2.Gegenstaende[2]="Tasche";
Lager2.Gegenstaende[3]="Bolzenschneider";
Lager2.Gegenstaende[4]="Schublade";
Lager2.Gegenstaende[5]="Regal";
Lager2.Gegenstaende[6]="Schere";
Lager2.Gegenstaende[7]="Karton";
Lager2.Gegenstaende[8]="Schrank2";
Lager2.Zugaenge[0] =4;

Lager Lager3=new Lager();
Lager3.RaumNr=3;
Lager3.CharakterAnw=false;
Lager3.Access =false;
Lager3.Gegenstaende[9]="Schrank3";
Lager3.Gegenstaende[10]="Regal2";
Lager3.Gegenstaende[11]="Klo";
Lager3.Zugaenge[0] =4;

Lager Freezer=new Lager();
Freezer.RaumNr=4;
Freezer.CharakterAnw=false;
Freezer.Access =true;
Freezer.Gegenstaende[0]="Freezer";
Freezer.Zugaenge[0] =4;


Console.WriteLine("**********************************");
Console.WriteLine("*                                *");
Console.WriteLine("*          WILKOMMEN! 🎉          *");
Console.WriteLine("*                                *");
Console.WriteLine("**********************************");

Console.WriteLine("");
bool flag=true;

    do
    {
        Console.WriteLine("Bitte geben sie eine Zahl");
        Console.WriteLine("1 = Start");
        Console.WriteLine("2 = Beenden");
        Console.WriteLine("3 = Anleitung");
        string Eingabe_str= Console.ReadLine();

       
        if(Eingabe_str=="1")
        {
        bool raum=true;

        Console.Clear(); 

        Console.WriteLine("Bitte betreten sie einen Raum");
        Console.WriteLine("1 = Lager 1");
        Console.WriteLine("2 = Lager 2");
        Console.WriteLine("3 = Lager 3");
        Console.WriteLine("4 = Freezer");
        Console.WriteLine("5 = Zurück");

        string Eingabe_raum= Console.ReadLine();

        do
        {
            if(Eingabe_raum=="1")
            {
                raum=false;

            }
            else if(Eingabe_raum=="2")
            {
                 raum=false;

            }
            else if(Eingabe_raum=="3")
            {
                Console.Clear();
                raum=false;
                Console.WriteLine("Hinweis: 2 Codes für den Freezer sind in diesem Lager versteckt. Suche nach Hinweisen!");
        
                RaetselSchalter();
                RaetselSchrank();
    

            void RaetselSchalter()
            {
                Console.WriteLine("Es gibt mehrere Schalter in diesem Raum. Finde die richtige Reihenfolge!");
                int[] richtigeReihenfolge = { 2, 4, 1, 3 };
                int[] eingabe = new int[4];
                
                for (int i = 0; i < 4; i++)
                {
                    Console.Write("Schalter " + (i + 1) + ": ");
                    eingabe[i] = int.Parse(Console.ReadLine());
                }
                
                if (Enumerable.SequenceEqual(eingabe, richtigeReihenfolge))
                {
                    Console.WriteLine("Richtig! Du erhältst eine Nummer: 7");
                }
                else
                {
                    Console.WriteLine("Falsche Reihenfolge! Versuche es erneut.");
                    RaetselSchalter();
                }
                }

                void RaetselSchrank()
                {
                Console.WriteLine("Der Schrank ist geschlossen. Löse das Buchstaben-Zahlen-Code-Rätsel!");
                Console.Write("");
                Console.WriteLine("Hinweis: Welche Nummern haben die Buchstaben im Alphabet? (T = , L = , R = )");
                Console.WriteLine("");
                
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
            else if(Eingabe_raum=="4")
            {
                 raum=false;

            }
            else if(Eingabe_raum=="5")
            {
                raum = false;
                return;
    
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Zahl ungültig");
            }
        

        }while(raum == true);
    
        flag =false; 
    }
    else if(Eingabe_str=="2")
    {
         Console.Clear();
         Console.WriteLine("Auf Wiedersehen");
         flag = false; 
         break;
         
    }
    else if(Eingabe_str=="3")
    {
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("*********************************************************************************");
        Console.WriteLine("*                                                                               *");
        Console.WriteLine("*   Sie sind Konsti, Konsti ist ein Mitarbeiter in einen Bürgerladen            *");
        Console.WriteLine("*   ihre Mission ist es die Bürgerpatties zu finden, hierfür müssen sie,        *");
        Console.WriteLine("*   den Code für den Freezer zu finden, um den zu bekommen                      *");
        Console.WriteLine("*   müssen sie underschieliche Rätsel lösen.                                    *");
        Console.WriteLine("*                                                                               *");
        Console.WriteLine("*********************************************************************************");

        flag = true;
        
    }
    else 
    {
        Console.Clear();
        Console.WriteLine("Zahl ungültig");
        flag = true;
    }
    
    }while(flag==true);
      
    