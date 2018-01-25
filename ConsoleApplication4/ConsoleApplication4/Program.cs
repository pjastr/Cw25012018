using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class StreamMovie : IMovie, IBuffered
    {
        byte[] buffor;
        public byte[] GetBufferedData()
        {
            //wczytaj dane z sttrumienia do buffora
            return buffor;
        }

        public void PlayMovie()
        {
            //odczytaj z buffora dane
            byte[] data = GetBufferedData();
            //uruchom film ...
        }
    }


}
