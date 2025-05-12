using System;

namespace KareAlUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(kareal(5));        // int
            Console.WriteLine(kareal(5.1));      // double
            Console.WriteLine(kareal("3"));      // string
            Console.Read();                      // Uygulamanın hemen kapanmasını önler
        }

        // int parametreli kareal metodu
        static int kareal(int x)
        {
            return x * x;
        }

        // double parametreli kareal metodu
        static double kareal(double x)
        {
            return x * x;
        }

        // string parametreli kareal metodu
        static int kareal(string x)
        {
            return Int32.Parse(x) * Int32.Parse(x);
        }
    }
}
