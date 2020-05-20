using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Linq_skoki
{
    class Skoczek
    {
        public string imie;
        public string nazwisko;
        public string kraj;
        public int rocznik;
        public double metry1seria;
        public double metry2seria;
        public double punkty1seria;
        public double punkty2seria;
        public double punkty;

        public override string ToString()
        {
            string dane = imie + " " + nazwisko + " (" + kraj + ", " + rocznik + ")";
            string wynik1 = metry1seria + " m / " + punkty1seria;
            string wynik2 = metry2seria + " m / " + punkty2seria;
            return dane + ": " + punkty + " (1 seria: " + wynik1 + ", 2 seria: " +
           wynik2 + ")";
        }
    }

    class NazwaKraju
    {
        public string skrot;
        public string nazwa;
        public double rekord;

        public NazwaKraju(string _skrot, string _nazwa, double _rekord)
        {
            skrot = _skrot;
            nazwa = _nazwa;
            rekord = _rekord;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Skoczek> wyniki = new List<Skoczek>();

            string tekst = File.ReadAllText(@"Planica.txt");
            string[] pozycje = tekst.Split('\n');

            foreach (string pozycja in pozycje)
            {
                string[] pola = pozycja.Split(';');
                Skoczek nowy = new Skoczek();
                nowy.nazwisko = pola[0].Trim();
                nowy.imie = pola[1].Trim();
                nowy.rocznik = Int32.Parse(pola[2].Trim());
                nowy.kraj = pola[3].Trim();
                nowy.metry1seria = Double.Parse(pola[4].Trim());
                nowy.punkty1seria = Double.Parse(pola[5].Trim());
                nowy.metry2seria = Double.Parse(pola[6].Trim());
                nowy.punkty2seria = Double.Parse(pola[7].Trim());
                nowy.punkty = Double.Parse(pola[8].Trim());
                wyniki.Add(nowy);
            }
            
            List<NazwaKraju> kraje = new List<NazwaKraju>();
            kraje.Add(new NazwaKraju("POL", "Polska", 251.5));
            kraje.Add(new NazwaKraju("GER", "Niemcy", 248));
            kraje.Add(new NazwaKraju("NOR", "Norwegia", 252));
            kraje.Add(new NazwaKraju("ITA", "Włochy", 232.5));
            kraje.Add(new NazwaKraju("SLO", "Słowenia", 250));
            kraje.Add(new NazwaKraju("JPN", "Japonia", 243));
            kraje.Add(new NazwaKraju("AUT", "Austria", 253.5));
            kraje.Add(new NazwaKraju("USA", "Stany Zjednoczone", 244.5));
            kraje.Add(new NazwaKraju("SUI", "Szwajcaria", 239.5));
            kraje.Add(new NazwaKraju("RUS", "Rosja", 233.5));
            kraje.Add(new NazwaKraju("CZE", "Czechy", 236));

            // 1)
            var list = wyniki.Where(skoczek => skoczek.nazwisko.Length >= 10).ToList();

            foreach (var skoczek in list)
            {
                Console.WriteLine(skoczek);
            }
            Console.WriteLine();

            // 2) bez uwzględnienia punktów za odległość
            foreach (var skoczek in wyniki)
            {
                Console.WriteLine(skoczek);
            }
            Console.WriteLine();

            // 3) z uwzględnieniem punktów za odlegość
            var wynikiDokladne = wyniki.Select(v =>
            {
                v.punkty -= (punkty_za_odleglosc(v.punkty1seria) + punkty_za_odleglosc(v.punkty2seria));
                return v;
            }).ToList();

            foreach (var wynik in wynikiDokladne)
            {
                Console.WriteLine(wynik);
            }
            Console.WriteLine();

            // 4) 
            var pogrupowaneKrajem = wyniki
                .GroupBy(wynik => wynik.kraj)
                .Select(grupa => new
                {
                    Name = kraje.Where(kraj => kraj.skrot == grupa.Key).Select(kraj => kraj.nazwa).First(),
                    Count = grupa.Count()
                })
                .OrderBy(n => n.Name);

            foreach (var item in pogrupowaneKrajem)
            {
                Console.WriteLine($"Kraj: {item.Name}\nLiczba zawodników: {item.Count}\n");
            }

            // 5)
            var bliscyRecordu = wyniki.Select(n => n)
                .Where(n => 
                    kraje.Where(kraj => kraj.skrot == n.kraj).Select(n => n.rekord).First() - n.metry1seria <= 10
                    ||
                    kraje.Where(kraj => kraj.skrot == n.kraj).Select(n => n.rekord).First() - n.metry2seria <= 10
                );

            foreach (var item in bliscyRecordu)
            {
                Console.WriteLine(item);
                Console.WriteLine($"Rekord w jego kraju: {kraje.Find(n => n.skrot == item.kraj).rekord}");
            }

            Console.ReadKey(true);
        }

        private static double punkty_za_odleglosc(double odleglosc)
        {
            return 120 + (odleglosc - 200) * 1.2;
        }
    }
}
