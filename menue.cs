using System;
static class menue
{
    public static void menue_anzeigen()
    {
        Console.WriteLine("****************************************************");
        Console.WriteLine("*                                                  *");
        Console.WriteLine("*          Willkommen bei road to Feierabend 🎉    *");
        Console.WriteLine("*                                                  *");
        Console.WriteLine("****************************************************");

        bool flag=true;

        do
        {
            Console.WriteLine("");
            Console.WriteLine("Bitte geben sie eine Zahl ein.");
            Console.WriteLine("1 = Start");
            Console.WriteLine("2 = Beenden");
            Console.WriteLine("3 = Anleitung");

            string Eingabe_str;
            
            Eingabe_str= Console.ReadLine();

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

        }
}
