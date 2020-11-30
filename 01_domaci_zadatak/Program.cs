﻿using System;

namespace _01_domaci_zadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.1.2 - Ispis brojeva
            //Napišite program koji na konzoli ispisuje
            //brojeve 1,2,3 svaki u novi red.
            Console.WriteLine("Zadatak 4.1.2:");
            Console.WriteLine("1 \n2 \n3");

            //4.1.3 - Ledište/Vrelište
            //Napišite program koji će ispisivati temperaturu ledišta i vrelišta
            //vode, svaku u novi red
            Console.WriteLine("\nZadatak 4.1.3:");
            Console.WriteLine("Temperatura ledišta vode je 0°C \nTemperatura vrelišta vode je 100°C\n");

            //5.1.1 - Zbroj i razlika
            //Program koji traži unos 2 cijela broja i prikazuje
            //na ekranu njihov zbroj te razliku
            Console.WriteLine("\nZadatak 5.1.1 - zbrajanje:");
            float a, b;
            Console.WriteLine("Unesite prvi broj:");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Unesite drugi broj:");
            b = float.Parse(Console.ReadLine());
            float c = a + b;
            Console.WriteLine("Dobili ste broj {0:#.##}.", c);

            Console.WriteLine("\nZadatak 5.1.1 - oduzimanje:");
            float d, e;
            Console.WriteLine("Unesite prvi broj:");
            d = float.Parse(Console.ReadLine());
            Console.WriteLine("Unesite drugi broj:");
            e = float.Parse(Console.ReadLine());
            float f = d - e;
            Console.WriteLine("Dobili ste broj {0:F}.", f);

            //5.1.2 - Umnožak i kvocijent
            //Program koji traži unos 2 cijela broja i prikazuje 
            //umnožak i kvocijent


            Console.WriteLine("\nZadatak 5.1.2 - množenje:");
            float g, h;
            Console.WriteLine("Unesite prvi broj:");
            g = float.Parse(Console.ReadLine());
            Console.WriteLine("Unesite drugi broj:");
            h = float.Parse(Console.ReadLine());
            float i = g * h;
            Console.WriteLine("dobili ste broj {0:F}.", i);

            Console.WriteLine("\nZadatak 5.1.2 - dijeljenje:");
            float j, k;
            Console.WriteLine("Unesite prvi broj:");
            j = float.Parse(Console.ReadLine());
            Console.WriteLine("Unesite drugi broj:");
            k = float.Parse(Console.ReadLine());
            float l = j / k;
            Console.WriteLine("Dobili ste broj {0:F}.", l);
        }
    }
}
