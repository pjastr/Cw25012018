using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    interface IMovie    
    {
        void PlayMovie();
    }

    interface IBuffered
    {
        byte[] GetBufferedData();
    }
}
