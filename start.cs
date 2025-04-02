using System;

static class Start
{
    public static void start_mth()
    {
        bool flagge = false;

        Console.WriteLine("Bitte betreten sie einen Raum");
        Console.WriteLine("1 = Lager 1");
        Console.WriteLine("2 = Lager 2");
        Console.WriteLine("3 = Lager 3");
        Console.WriteLine("4 = Freezer");
        Console.WriteLine("5 = Zurück");

        string Eingabe_raum= Console.ReadLine();

        do
        {
            if(Eingabe_raum == "1")
            {
                flagge = true;
                raetsel.r1();

            }
            else if(Eingabe_raum == "2")
            {
                
                flagge = true;
                raetsel.r2();
                


            }
            else if(Eingabe_raum == "3")
            {
                flagge = true;
                raetsel.r3();

            }
            else if(Eingabe_raum == "Freezer")
            {
                flagge = true;
                raetsel.r4();


            }
            else if(Eingabe_raum == "Zurück")
            {
                menue.menue_anzeigen();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Zahl ungültig");
                flagge = false;
            }

        }while(flagge == false);

        

              

    }

    
}

