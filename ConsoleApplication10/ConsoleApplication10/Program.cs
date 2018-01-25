using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Postac
    {
        public string Nazwa;
        public int Zycie;

        public Postac(string name, int zycie)
        {

        }

        public void Porusz(Vector kierunek, float dystans)
        {

        }
    }

    class Wojownik:Postac
    {
        private int sila;

        public Wojownik(int sila)
            :base("ddd",2)
        {
            
        }
    }

    class Mag:Postac
    {
        private int mana;

        public Mag(int mana)
            :base("Mag",2344)
        {
            this.mana = mana;
        }
    }
}
