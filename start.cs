using System;
using System.Net.Mail;

static class Start
{
    public static void start_mth()
    {
        bool flagge = false;

        Console.WriteLine("Bitte betreten sie einen Raum");
        Console.WriteLine("1 = Lager 1");
        Console.WriteLine("2 = Lager 2");
        Console.WriteLine("3 = Lager 3");
        Console.WriteLine("4 = Lager 4");
        Console.WriteLine("5 = Freezer");
        Console.WriteLine("6 = Zurück");

        string Eingabe_raum= Console.ReadLine();

        do
        {
            if(Eingabe_raum == "1")
            {
                if( Lager.alleRaeume[0].Access==true)
                {
                    raetsel.r1();
                    Lager.alleRaeume[0].Access=false;
                }
                else
                {
                    Console.WriteLine("Sie haben den Lager bereits geschafft ");
                    menue.menue_anzeigen();

                }
                flagge = true;
               

            }
            else if(Eingabe_raum == "2")
            {
                if( Lager.alleRaeume[1].Access==true)
                {
                    raetsel.r2();
                    Lager.alleRaeume[1].Access=false;
                }
                else
                {
                    Console.WriteLine("Sie haben den Lager bereits geschafft ");
                    menue.menue_anzeigen();

                }
                
                flagge = true;
              
            }
            else if(Eingabe_raum == "3")
            {

                if( Lager.alleRaeume[2].Access==true)
                {
                    raetsel.r3();
                    Lager.alleRaeume[2].Access=false;
                }
                else
                {
                    Console.WriteLine("Sie haben den Lager bereits geschafft ");
                    menue.menue_anzeigen();
                }
                flagge = true;

            }
            else if (Eingabe_raum == "4")
            {
                if( Lager.alleRaeume[3].Access==true)
                {
                    raetsel.r4();
                    Lager.alleRaeume[3].Access=false;
                }
                else
                {
                    Console.WriteLine("Sie haben den Lager bereits geschafft ");
                    menue.menue_anzeigen();
                }
                flagge= true;
    
            }
            else if(Eingabe_raum== "5")
            {
                if( Lager.alleRaeume[4].Access==true)
                {
                    raetsel.r5();
                    Lager.alleRaeume[4].Access=false;
                }
                else
                {
                    Console.WriteLine("Sie haben den Lager bereits geschafft ");
                    menue.menue_anzeigen();

                }
                flagge=true;
                
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
                menue.menue_anzeigen();
            }

        }while(flagge == false);

    }

    
}

