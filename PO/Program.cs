

using System;

namespace PO
{
    class Program 
    {
        static void Main(string[] args)
        {
                //zad1

            // Console.WriteLine("Ile Celsjuszy: ");
            // float temp;
            // temp = Convert.ToSingle(Console.ReadLine());
            // float konwersja = 32 + ((9 * temp)/5);
            // Console.WriteLine($"Fahrenheit wynosi: {konwersja}");

                //zad2

            // int a = 0;
            // int b = 0;
            // int c = 0;

            // Console.WriteLine("Podaj a: ");
            // a = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Podaj b: ");
            // b = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Podaj c: ");
            // c = Convert.ToInt32(Console.ReadLine());

            // int delta = ((b * b) - (4 * a * c));
            // Console.WriteLine($"Delta: {delta}");

                //zad3

            // float waga;
            // float wzrost;

            // Console.WriteLine("Podaj swoją wage w kilogramach: ");
            // waga = Convert.ToSingle(Console.ReadLine());
            // Console.WriteLine("Podaj swój wzrost w metrach: ");
            // wzrost = Convert.ToSingle(Console.ReadLine());

            // float bmi = waga/wzrost;
            // Console.WriteLine($"Twoje BMI wynosi: {bmi}");
            // Console.ReadKey();

                //zad4

            // int x = 100;
            // Console.WriteLine(++x * 2);

                //zad5

            // int x = 2, y = 3;
            // Console.WriteLine(x *= y * 2);

                //zad6

            // int x, y = 4;
            // x = (y -=2);
            // x = y++;
            // x = y--;
            // Console.WriteLine(x);

                //zad7

            // int x, y = 5;
            // x = ++y * 2;
            // x = y++;
            // x = y--;
            // Console.WriteLine(++y);

                //zad8

            // bool x;
            // int y = 1, z = 1;
            // x = (y == 1 && z++ == 1);
            // Console.WriteLine(x + " " + y + " " + z);

                //zad9

            //a
            // int x = 1, y = 4, z = 2;
            // bool wynik =(x++ > 1 && y++ == 4 && z--> 0);
            // Console.WriteLine("wynik={0} x={1}  y={2}  z={3}", wynik, x, y, z);

            //b
            // int x = 1, y = 4, z = 2;
            // bool wynik = (x++ > 1 & y++ == 4 && z--> 0);
            // Console.WriteLine("wynik={0} x={1}  y={2}  z={3}", wynik, x, y, z);

            //c
            // int x = 1, y = 4, z = 2;
            // bool wynik = (x++ > 1 & y++ == 4 & z--> 0);
            // Console.WriteLine("wynik={0} x={1}  y={2}  z={3}", wynik, x, y, z);

            //d
            // int x = 1, y = 3, z = 4;
            // bool wynik = (x == 1 || y++ > 2 || ++z > 0);
            // Console.WriteLine("wynik={0} x={1}  y={2}  z={3}",wynik, x, y, z);

            //e
            // int x = 1, y = 3, z = 4;
            // bool wynik = (x == 1 | y++ > 2 || ++z > 0);
            // Console.WriteLine("wynik={0} x={1}  y={2}  z={3}", wynik, x, y, z);

            //f
            // int x = 1, y = 3, z = 4;
            // bool wynik = (x == 1 | y++ > 2 | ++z > 0);
            // Console.WriteLine("wynik={0} x={1}  y={2}  z={3}", wynik, x, y, z);

                //zad10

            // int powierzchnia = 100, osoby = 10;
            // double gestosc = osoby/powierzchnia;
            // Console.WriteLine(gestosc);


            // double powierzchnia = 100, osoby = 10;
            // double gestosc= osoby/powierzchnia;
            // Console.WriteLine(gestosc);

        }
    }
}
