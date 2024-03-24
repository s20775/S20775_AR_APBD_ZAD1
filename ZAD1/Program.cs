namespace ZAD1
{
    internal class Program
    {
        static void Main()
        {
            int[] tablicaLiczb = { 5, 10, 15, 20, 25 };
            double srednia = liczSrednia(tablicaLiczb);
            Console.WriteLine("Średnia: " + srednia);

            int maksymalnaWartosc = ZnajdzMaksymalnaWartosc(tablicaLiczb);
            Console.WriteLine("Maksymalna wartość: " + maksymalnaWartosc);
        }

        static double liczSrednia(int[] tablica)
        {
            if (tablica == null || tablica.Length == 0)
            {
                throw new ArgumentException("Tablica jest pusta lub null.");
            }

            int suma = 0;
            foreach (int liczba in tablica)
            {
                suma += liczba;
            }

            return (double)suma / tablica.Length;
        }

        static int ZnajdzMaksymalnaWartosc(int[] tablica)
        {
            if (tablica == null || tablica.Length == 0)
            {
                throw new ArgumentException("Tablica jest pusta lub null.");
            }

            int maksymalnaWartosc = tablica[0];
            foreach (int liczba in tablica)
            {
                if (liczba > maksymalnaWartosc)
                {
                    maksymalnaWartosc = liczba;
                }
            }

            return maksymalnaWartosc;
        }
    }
}