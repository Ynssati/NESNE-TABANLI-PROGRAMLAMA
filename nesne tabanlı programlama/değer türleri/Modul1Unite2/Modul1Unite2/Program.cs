using System;

public struct Tarih
{
    public int gun;
    public int ay;
    public int yil;

    
    public Tarih(int gun, int ay, int yil)
    {
        this.gun = gun;
        this.ay = ay;
        this.yil = yil;
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Tarih bugun = new Tarih(11, 5, 2025);

       
        Console.WriteLine($"Bugünün tarihi: {bugun.gun}/{bugun.ay}/{bugun.yil}");
    }
}
