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

// Initialisierung


{
 }
 
/*
Console.WriteLine("Das ist ein kleines Beispiel für ein (langweiliges) Exit Game. \nIhr könnt es besser, viel Spaß! ");
Console.WriteLine("-----------------------------------------------------------------------");
Console.WriteLine("Geisterspiel");
int punkte = 0;
bool gameover = false;
Random random = new Random();
while (gameover == false)
{
    Console.WriteLine("Hinter einer Tür verbirgt sich ein Geist.\nWelche Tür wählst du? 1, 2 oder 3?");
    int tuer = Convert.ToInt32(Console.ReadLine());
    int geisterTuer = random.Next(1, 4);
    if (tuer == geisterTuer)
    {
        Console.WriteLine("Game over! Hier ist ein Geist!");
        Console.WriteLine("Deine Punkte: {0}", punkte);
        gameover = true;
    }
    else
    {
        Console.WriteLine("Kein Geist gefunden!");
        punkte = punkte + 1;
    }
}
*/
