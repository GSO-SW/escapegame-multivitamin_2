


  

using System;
using System.Linq;

public class Lager
{
    public int RaumNr;
    public bool Access;

    public Lager(int Nr, bool Zugaenge)
    {
        RaumNr=Nr;
        Access=Zugaenge;
        alleRaeume.Add(this);
    }


    public static List<Lager> alleRaeume = new List<Lager>();


    public static void ErstelleRaum()
    {
        alleRaeume.Add(new Lager(1,true));
        alleRaeume.Add(new Lager(2,true));
        alleRaeume.Add(new Lager(3,true));
        alleRaeume.Add(new Lager(4,true));
        alleRaeume.Add(new Lager(5,true));

    }
    public void RaumBetreten()
    {
        Globals.aktuellerRaum= this;

    }
    
}

