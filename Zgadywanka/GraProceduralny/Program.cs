using System;
using System.Diagnostics;

namespace GraProceduralny
{
    class Program
    {
        const string zaduzo = "ZA DUZO";
        const string zamalo = "ZA MALO";
        const string trafiono = "TRAFIONO";
        static void Main(string[] args)
        {
            Console.WriteLine("Gra za duzo za malo!");
            int a = WczytajLiczbe("Podaj dolny zakres losowania: ");
            int b = WczytajLiczbe("Podaj gorny zakres losowania: ");
            
            int wylosowana = Losuj(a, b);
#if DEBUG
            Console.WriteLine(wylosowana);
#endif
            int licznik = 0;
            var stoper = new Stopwatch();
            stoper.Start();
            while (true)
            {
                //2. Czlowiek proponuje
                licznik++; //licznik = licznik + 1;
                int propozycja = WczytajLiczbe("Podaj swoje propozycje lub x aby zakonczycz: ");
                string wynik = Ocena(wylosowana, propozycja);
                Console.WriteLine(wynik);
                if (wynik == trafiono)
                    break;
                
            }
            stoper.Stop();
            Console.WriteLine($"liczba ruchow = {licznik}");
            Console.WriteLine($"cas gry= {stoper.Elapsed}");
            Console.WriteLine("Koniec gry");
        }

        /// <summary>
        /// Losuje liczbe z podanego zakresu wlacznie
        /// 
        /// </summary>
        /// <param name="min">dolne ograniczenie</param>
        /// <param name="max">gorne ograniczenie</param>
        /// <returns></returns>
        static int Losuj(int min = 1, int max = 100)
        {
            var min1 = Math.Min(min, max);
            var max1 = Math.Max(min, max);
            var rnd = new Random();
            var los = rnd.Next(min1, max1 + 1);

            return los;
        }


        static int WczytajLiczbe(string prompt = "")


        {
            bool poprawnie = false;
            int wynik = 0;
            do
            {
                Console.Write(prompt);
                string wczytano = Console.ReadLine();
                if (wczytano == "x" || wczytano == "x")
                    Environment.Exit(0);


                try
                {

                    wynik = int.Parse(wczytano);
                    poprawnie = true;
                }

                catch (FormatException)
                {
                    Console.WriteLine("niepoprawny zapis liczby.Sproboj jeszcze raz");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("przekroczone zakres");
                }
                catch (Exception)
                {
                    Console.WriteLine("nieznany blad");

                }
            }
            while (!poprawnie);

            return wynik;

        }

        static string Ocena( int wylosowana, int propozycja )
        {
            if( wylosowana < propozycja )
            {
                return zaduzo;
            }
            else if( wylosowana > propozycja )
            {
                return zamalo;
            }
            else
            {
                return trafiono;
            }
        }
    }
}