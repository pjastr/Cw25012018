using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            Firma f = new Firma();
            f.DodajPracownika("Jan Kowalski");
            f.DodajPracownika("Adam Nowak");

            foreach (var prac in f)
            {
                Console.WriteLine(prac);
            }

        }
    }

    public class Firma:IEnumerable
    {
        List<string> pracownicy;
        public Firma()
        {
            pracownicy = new List<string>();
        }

        public void DodajPracownika(string param)
        {
            pracownicy.Add(param);
        }

        public IEnumerator GetEnumerator()
        {
            foreach(var element in pracownicy)
            {
                yield return element;
            }
        }

    }

}
