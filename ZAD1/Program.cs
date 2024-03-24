namespace ZAD1
{
    internal class Program
    {
        static void Main()
        {
            int[] tablicaLiczb = { 5, 10, 15, 20, 25 };
            double srednia = ObliczSrednia(tablicaLiczb);
            Console.WriteLine("Średnia: " + srednia);
        }

        static double ObliczSrednia(int[] tablica)
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
    }
}