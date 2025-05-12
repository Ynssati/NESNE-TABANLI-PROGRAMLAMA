using System;

class Program
{
    static void Main(string[] args)
    {
        int toplamen = Program.toplam(9, 4, 5, 6, 19);
        Console.WriteLine(toplamen);
        Console.Read();
    }

    public static int toplam(params int[] paramList)
    {
        int c = paramList[0];
        int d = paramList[0];

        foreach (int i in paramList)
        {
            if (i < c)
                c = i;
        }

        foreach (int i in paramList)
        {
            if (i > d)
                d = i;
        }

        return c + d;
    }
}
