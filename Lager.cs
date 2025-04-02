


  

using System;
using System.Linq;


public class Lager
{
  
    public int Nr;
    public string Name;
    public bool Begehbar;

    public static List<Lager> alleRaeume = new List<Lager>();

        //Berechnete Eigenschaft (Charakter anwesend oder nicht?)
    public bool CharakterAnwesenheit
    { 
        get { if (Globals.aktuellerRaum == this)
                return true;
                return false;
                    } 

    }

    //Konstruktor
    public Lager(int raumNr, string raumName, bool raumBegehbar)
    {
        Nr = raumNr;
        Name = raumName;
        Begehbar = raumBegehbar;
        alleRaeume.Add(this);
    }

    //Statische Methode, um alle Räume zu erstellen
    public static void ErstelleRaeume()
    {
        //Raum werkstatt wird erzeugt und der Liste "alleRaeume" hinzufügen
        //Werkstatt ist eine abgeleitete Klasse von Raum, s. Datei Werkstatt.cs)
        alleRaeume.Add(new Lager(1, "Lager 1", true));
        alleRaeume.Add(new Lager(2, "Lager 2", false));
        alleRaeume.Add(new Lager(3, "Lager 3", false));
        alleRaeume.Add(new Lager(4, "Lager 4", false));
        alleRaeume.Add(new Lager(5, "Freezer 5", false));


        //Hier weitere Räume ergänzen und der Liste hinzufügen
    }

    //Methoden

    //Raum kann betreten werden mit dieser Methode
    public void RaumBetreten()
    {
        Globals.aktuellerRaum = this;
    }

    //eine virtuelle Methode, die für alle Räume speziell implementiert werden kann (s. Beispiel Werkstatt)
    

  
    
}





       
       