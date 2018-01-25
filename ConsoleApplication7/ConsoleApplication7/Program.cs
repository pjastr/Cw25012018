using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<DateTime>> prac = new Dictionary<string, List<DateTime>>();
            prac.Add("Nowak", new List<DateTime>() { new DateTime(2017, 2, 11), new DateTime(2017, 2, 13) });
            prac.Add("Kowalski", new List<DateTime>() { new DateTime(2017, 2, 1)});
        }
    }
}
