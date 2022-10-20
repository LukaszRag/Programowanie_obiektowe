using System;

namespace Kurs
{
    class Program
    {
        static void Main(string[] args)
        {
            //zad3.a
        //    Console.WriteLine("Wprowadz liczbe calkowita");
        //    int liczba = int.Parse(Console.ReadLine());
        //   if (liczba %2==0)
        //        Console.WriteLine("{0} jest liczbą parzysta",liczba);
        //    else
        //        Console.WriteLine("{0} jest liczbą nieparzysta",liczba);
        //   if (liczba<0)
        //        Console.WriteLine("{0} jest liczbą ujemna",liczba);
        //   else
        //        Console.WriteLine("{0} nie jest liczbą ujemna",liczba);
        //   Console.ReadKey();



            //zad3.b
        // Console.WriteLine("Wprowadź liczbę 1");
        // int liczba1 = int.Parse(Console.ReadLine());
        // Console.WriteLine("Wprowadź liczbę 2");
        // int liczba2 = int.Parse(Console.ReadLine());
        // Console.Write("Liczby parzyste: ");
        // if(liczba1 <= liczba2)
        // {
            // for(int i = liczba1; i <= liczba2; i++)
            // {
                    // if(i % 2 == 0)
                    // {
                       // Console.Write(i + ","); 
                    // }
            // }
        // }
        // Console.ReadKey();

            //zad3.1
        // Console.WriteLine("Podaj rok do sprawdzenia, czy jest przestepny: ");
        // int rok = int.Parse(Console.ReadLine());
        // if (rok % 4==0)
        // {
            // if(rok % 100 == 0){
                // if(rok % 400 == 0)
                  // Console.WriteLine(" jest przestepny.");    
                // else
                 // Console.WriteLine("Nie jest przestepny.");            
            // }
            // else
            // Console.WriteLine(" jest przestepny.");  
        
        // }
        // else
        // Console.WriteLine("Nie jest przestepny.");  
        
        // Console.ReadKey();

            //zad3.2
        // Console.WriteLine("Podaj 1 liczbe:");
        // int liczba1 = int.Parse(Console.ReadLine()); 
        // Console.WriteLine("Podaj 2 liczbe:");
        // int liczba2 = int.Parse(Console.ReadLine()); 
        // if(liczba1 % liczba2 ==0 )
             // Console.WriteLine("Liczba druga jest dzielnikiem pierwszej."); 
        // else 
          // Console.WriteLine("Liczba druga nie jest dzielniekiem pierwszej.");
        // Console.ReadKey();

            //zad3.4
        // Console.WriteLine("Podaj 1 liczbe:");
        // double liczba1 = double.Parse(Console.ReadLine()); 
        // Console.WriteLine("Podaj 2 liczbe:");
        // double liczba2 = double.Parse(Console.ReadLine());
        // Console.WriteLine("Wpisz numer działania, którego chcesz wykonać: 1-dodawanie, 2-odejmowanie, 3-mnożenie, 4-dzielenie.");
        // int a = int.Parse(Console.ReadLine());

        // switch(a)
        // {
            // case 1:
            // Console.WriteLine(liczba1 + liczba2);
            // break;

            // case 2:
            // Console.WriteLine(liczba1 - liczba2);
            // break;

            // case 3:
            // Console.WriteLine(liczba1 * liczba2);
            // break;

            // case 4:
            // Console.WriteLine(liczba1 / liczba2);
            // break;
        // }
        // Console.ReadKey();

            //zad3.3
        // Console.WriteLine("Podaj 1 liczbe:");
        // int a = int.Parse(Console.ReadLine());
        // Console.WriteLine("Podaj 2 liczbe:");
        // int b = int.Parse(Console.ReadLine());
        // Console.WriteLine("Podaj 3 liczbe:");
        // int c = int.Parse(Console.ReadLine());

        // if(a>b && a>c){
        //    Console.WriteLine("{0} jest najwieksza",a);
        // }
        // else if(b>a && b>c){
        //    Console.WriteLine("{0} jest najwieksza",b);
        // }
        // else if(c>a && c>b){
        //    Console.WriteLine("{0} jest najwieksza",c);
        // }
        // Console.ReadKey();

            //zad3.5
        // Console.WriteLine("ax^2+bx+c=0");
        // Console.WriteLine("Podaj a");
        // int a = int.Parse(Console.ReadLine());
        // Console.WriteLine("Podaj b");
        // int b = int.Parse(Console.ReadLine());
        // Console.WriteLine("Podaj c");
        // int c = int.Parse(Console.ReadLine());
        // Console.WriteLine("{0}x^2+{1}x+{2}=0",a,b,c);
        // int delta = (b*b)-(4*a*c);
        // if(delta==0){
            // int zerowa = (-b)/(2*a);
            // Console.WriteLine(zerowa);
        // }
        // else if(delta>0){
            // double x1 = (-b+Math.Sqrt(delta)/2*a);
            // double x2 = (-b-Math.Sqrt(delta)/2*a);
            // Console.WriteLine("{0} to x1",x1);
            // Console.WriteLine("{0} to x2",x2);

        // }
        // else if(delta<0){
            // Console.WriteLine("Delta jest poniżej 0");
        // }
        // Console.ReadKey();

            //zad3.6

        // double masa, wzrost;
        // Console.WriteLine("Podaj masę w kg: ");
        // masa = Convert.ToDouble(Console.ReadLine());
        // Console.WriteLine("Podaj wzrost w m: ");
        // wzrost = Convert.ToDouble(Console.ReadLine());

        // double bmi = masa/(wzrost*wzrost);
        // Console.WriteLine($"Twoje BMI wynosi: {bmi}");

        // switch (bmi){
        //     case < 16.0:
        //         Console.WriteLine("Wygłodzenie");
        //         break;
        //     case >= 16.0 and <= 16.0:
        //         Console.WriteLine("Wychudzenie");
        //         break;
        //     case >= 17.0 and <= 18.5:
        //         Console.WriteLine("Niedowaga");
        //         break;
        //     case >= 18.6 and <= 24.9:
        //         Console.WriteLine("Waga prawidłowa");
        //         break;
        //     case >= 25.0 and <= 29.9:
        //         Console.WriteLine("Nadwaga");
        //         break;
        //     case >= 30.0 and <= 34.9:
        //         Console.WriteLine("Otyłość I stopnia");
        //         break;
        //     case >= 35.0 and <= 39.9:
        //         Console.WriteLine("Otyłość II stopnia");
        //         break;
        //     case >= 40.0:
        //         Console.WriteLine("Otyłość III stopnia");
        //         break;
        // }   

            //zad3.7

        // Console.WriteLine("Wpisz nr dnia tygodnia: ");
        // string numer = Console.ReadLine();
        // switch(numer){
        //     case "1":
        //         Console.WriteLine("Poniedziałek");
        //         break;
        //     case "2":
        //         Console.WriteLine("Wtorek");
        //         break;
        //     case "3":
        //         Console.WriteLine("Środa");
        //         break;
        //     case "4":
        //         Console.WriteLine("Czwartek");
        //         break;
        //     case "5":
        //         Console.WriteLine("Piątek");
        //         break;
        //     case "6":
        //         Console.WriteLine("Sobota");
        //         break;
        //     case "7":
        //         Console.WriteLine("Niedziela");
        //         break;
        //     default:
        //         Console.WriteLine("Nie ma takigeo dnia tygodnia");
        //         break;
        // }

            //zad3.8

        // Console.WriteLine("Podaj swoją średną ocen: ");
        // double avg = Convert.ToDouble(Console.ReadLine());

        // switch(avg){
        //     case >= 2.00 and <= 3.99:
        //         Console.WriteLine("Nie należy się stypednium");
        //         break;
        //     case >= 4.00 and <= 4.79:
        //         Console.WriteLine("Kwota stypendium: 350.00zł");
        //         break;
        //     case >= 4.80 and <= 5.00:
        //         Console.WriteLine("Kwota stypendium: 550.00zł");
        //         break;
        //     default:
        //        Console.WriteLine("Średnia została nieprawidłowo wpisana");
        //        break; 
        // }

            //zad3.9

        // static void treeOne(int a){
        //     for (int x = 1; x <= a; x++){
        //         for(int y = 1; y <= x; y++){
        //             Console.Write("*");
        //         }
        //         Console.Write("\n");
        //     }
        // }

        // static void treeTwo(int a){
        //     for (int x = 1; x<=a; x++){
        //         for (int y = (a - x); y >= 0; y--){
        //             Console.Write("*");
        //         }
        //         Console.Write("\n");
        //     }
        // }

        // static void treeThree(int a){
        //     for (int x = 1; x <= a; x++){
        //         for (int y = (a - x); y > 0; y--){
        //             Console.Write(" ");
        //         }
        //         for(int y = 1; y <= x; y++){
        //             Console.Write("*");
        //         }
        //         Console.Write("\n");
        //     }
        // }

        // static void treeFour(int a){
        //     for(int x = 1; x <= a; x++){
        //         Console.Write("*");
        //     }
        //     Console.Write("\n");
        //     for(int y = 1; y <= (a - 2); y++){
        //         Console.Write("*");
        //         for(int z = 1; z <= (a - 2); z++){
        //             Console.Write(" ");
        //         }
        //         Console.Write("*\n");
        //     }
        //     for(int x = 1; x <= a; x++){
        //         Console.Write("*");
        //     }
        //     Console.Write("\n");
        // }

        // Console.Write("Podaj ilość linii: ");
        // int param = Convert.ToInt32(Console.ReadLine());
        // Console.Write("Wybierz wariant drzewka: (1, 2, 3 lub 4): ");
        // int tree = Convert.ToInt32(Console.ReadLine());

        // switch(tree){
        //     case 1:
        //         treeOne(param);
        //         break;
        //     case 2:
        //         treeTwo(param);
        //         break;
        //     case 3:
        //         treeThree(param);
        //         break;
        //     case 4:
        //         treeFour(param);
        //         break;
        //     default:
        //         Console.WriteLine("Drzewko spoza podanego zakresu");
        //         break;
        // }

            //zad3.10

        // Console.Write("Podaj liczbę: ");
        // double factorial = Convert.ToDouble(Console.ReadLine());

        // double start = 1;
        // for (double x = 1; x<=factorial; x++){
        //     start = start * x;
        // }
        // Console.WriteLine(start);

            //zad3.11

        // int start = 0;
        // int increment = 0;
        // for (int x=1; x<=100; x++){
        //     start += x;
        //     if (start >= 100){
        //         Console.Write(increment);
        //         break;
        //     }
        //     else{
        //         increment++;
        //     }
        // }

            //zad3.12

        // double x=1;
        // while(x != 0){
        //     Console.WriteLine("Wpisz liczbę: ");
        //     x = Convert.ToDouble(Console.ReadLine());
        // }

            //zad3.13

        // Console.WriteLine("Podaj liczbę: ");
        // int a = Convert.ToInt32(Console.ReadLine());

        // int start = 0;

        // for (int x=1; x<=a; x++){
        //     if (x % 2 == 0){
        //         start -= x;
        //     }
        //     else{
        //         start += x;
        //     }
        // }
        // Console.WriteLine($"Wynik szeregu: {start}");

            //zad3.14

        // Console.WriteLine("Podaj ostatnią liczbę z zakresu: ");
        // int range = Convert.ToInt32(Console.ReadLine());

        // for (int x = 1; x<=range; x++){
        //     int inc = 0;
        //     for (int y = 1; y<x; y++){
        //         if ((x % y == 0) && (x != y)){
        //             inc+=y;
        //         }
        //     }
        //     if (inc == x){
        //         Console.WriteLine($"Liczba doskonała: {x}");
        //     }
        

        






    }
}}