using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            d

            //1. Komputer losuje
            #region losowanie

            var los = new Random(); // tworze objiekt typu Random
            int wylosowana = los.Next(1, 100+1);
#if DEBUG
            Console.WriteLine(wylosowana);
#endif
            Console.WriteLine("Wylosowalem liczbe od 1 do 100.\nOdgadnij ja!");
            #endregion

            bool odgadniete = false;
            // dopoki nie odgadniete
            while ( !odgadniete )
            {


                //2. Czlowiek proponuje
                Console.WriteLine("Podaj swoje propozycje: ");
                int propozycja = int.Parse(Console.ReadLine());

                //3. Komputer ocenia
                if (propozycja < wylosowana)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Za malo");
                    Console.ResetColor();
                }
                else if (propozycja > wylosowana)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Za duzo");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Trafiono");
                    Console.ResetColor();
                    odgadniete = true;
                }

                Console.WriteLine("Koniec gry");
            }


        }
    }
}
