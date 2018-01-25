using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Pokoj
    {
        int numer;
        int iloscOsob;

        public Pokoj()
        {
            this.numer = 100;
            iloscOsob = 2;
        }
    }

    class Hotel
    {
        public string Nazwa;
        public string Adres;
        public int LiczbaGwiazdek;
        List<Pokoj> pokoje = new List<Pokoj>();

        public Hotel(string nazwa)
        {

        }

        public void SprawdzRezerwacje(DateTime przyjazd)
        {

        }
    }
}
