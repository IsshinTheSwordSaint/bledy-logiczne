namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zadanie1
            /*  int wiek = 17;

              if (wiek >= 18) //tu powinno byc wiek >= 18

              {

                  Console.WriteLine("Jesteś pełnoletni");

              }
              else //tu powinno byc samo else
              {

                  Console.WriteLine("Jesteś niepełnoletni");

              }
            */

            //zadanie2
            /*
            int a = 10, b = 20, c = 30;

            int srednia = (a + b + c) / 3; //tu powinno byc (a + b + c) / 3

            Console.WriteLine($"Średnia: {srednia}");
            */

            //zadanie3
            /*
            int liczba = 7;

            if (liczba % 2 == 0) //tu powinno byc liczba % 2 == 0

            {

                Console.WriteLine("Liczba parzysta");

            }

            else

            {

                Console.WriteLine("Liczba nieparzysta");

            }
            */

            //zadanie4
            /*
            int a = 15, b = 20;

            int max = a;

            if (b > a)  //tu powinno byc b > a

            {

                max = b;

            }

            Console.WriteLine($"Maksimum: {max}");
            */

            //zadanie5
            /*
            double cena = 100;

            double rabat = 20; // 20% 

            double cenaPoRabacie = cena - (cena * rabat / 100);//tu powinno byc cena - (cena * rabat / 100)

            Console.WriteLine($"Cena po rabacie: {cenaPoRabacie}");
            */

            //zadanie6
            /*
            int[] tablica = { 64, 34, 25, 12, 22, 11, 90 };

            for (int i = 0; i < tablica.Length - 1; i++) 

            {

                for (int j = 0; j < tablica.Length - 1; j++) 

                {

                    if (tablica[j] > tablica[j + 1])

                    {                               

                        int temp = tablica[j]; 

                        tablica[j] = tablica[j + 1]; 

                        tablica[j + 1] = temp;

                    }

                }

            }   //dziala dobrze, zmienialem i dodawalem wartosci w tablicy i dziala dobrze,
                //na dole for ktory wysiwetla liczby po przesortowaniu
            for (int i = 0; i < tablica.Length; i++)
            {
                Console.Write(tablica[i] + " ");
            }
            */

            //zadanie7
            /*
            string wyraz = "Kajak";

            bool jestPalindromem = true;

            //tutaj chodzi o to ze wielkosc liter sie liczy, wiec "Kajak" nie jest palindromem,a "kajak" juz jest
            wyraz = wyraz.ToLower();
            for (int i = 0; i < wyraz.Length / 2; i++)

            {

                if (wyraz[i] != wyraz[wyraz.Length - 1 - i])

                {

                    jestPalindromem = false;

                    break;

                }

            }

            Console.WriteLine(jestPalindromem ? "Palindrom" : "Nie palindrom");
            */

            //zadanie8
            //w tym zadaniu bylo dobrze, nic nie zmienialem
            /*
            int n = 10;

            int a = 0, b = 1;

            Console.Write($"{a} {b} ");

            for (int i = 2; i <= n; i++)

            {

                int nastepna = a + b;

                Console.Write($"{nastepna} ");

                a = b;

                b = nastepna;

            }
            */

            //zadanie9
            /*
            //w tym zadaniu bylo dobrze, nic nie zmienialem, nizej dodalem kod, ktory sprawdza usuniecia
            List<int> liczby = new List<int> { 1, 2, 3, 2, 4, 3, 5, 1 };

            for (int i = 0; i < liczby.Count; i++)

            {

                for (int j = i + 1; j < liczby.Count; j++)

                {

                    if (liczby[i] == liczby[j])

                    {

                        liczby.RemoveAt(j);

                    }

                }

            }
            //kod ktory wyswietla liczby po usunieciu duplikatow
            Console.WriteLine("Liczby po usunięciu duplikatów:");
            foreach (var liczba in liczby)
            {
                Console.Write(liczba + " ");
            }
            */

            //zadanie10
            /*
            //w tym zadaniu bylo dobrze, nic nie zmienialem
            int liczba = 17;

            bool jestPierwsza = true;

            for (int i = 2; i < liczba; i++)

            {

                if (liczba % i == 0)

                {

                    jestPierwsza = false;

                    break;

                }

            }

            Console.WriteLine(jestPierwsza ? "Pierwsza" : "Złożona");
            */



        }
    }
}
