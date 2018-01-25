using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Moneta[,] monety = new Moneta[3, 2];
            monety[0, 0] = new Moneta() { Wartosc = 4 };
            monety[0, 1] = new Moneta() { Wartosc = 5 };
            monety[1, 0] = new Moneta() { Wartosc = 6 };
            monety[1, 1] = new Moneta() { Wartosc = 2 };
            monety[2, 0] = new Moneta() { Wartosc = 3 };
            monety[2, 1] = new Moneta() { Wartosc = 1 };
        }
    }

    class Moneta
    {
        public int Wartosc;
    }
}
