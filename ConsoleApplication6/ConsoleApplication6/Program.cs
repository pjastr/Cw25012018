using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<DateTime>> prac = new Dictionary<string, List<DateTime>>();
            List<DateTime> datyNowak = new List<DateTime>();
            datyNowak.Add(new DateTime(2017,2,11));
            datyNowak.Add(new DateTime(2017,2,13));
            prac.Add("Nowak", datyNowak);
            List<DateTime> datyKowalski = new List<DateTime>();
            datyKowalski.Add(new DateTime(2017, 2, 1));
            prac.Add("Kowalski", datyKowalski);
            foreach(var element in prac)
            {
                Console.WriteLine("Pracownik " + element.Key + " jego dyżury:");
                List<DateTime> daty = element.Value;
                foreach(var el2 in daty)
                {
                    Console.WriteLine(el2);
                }
            }

            Console.ReadKey();
        }
    }
}
