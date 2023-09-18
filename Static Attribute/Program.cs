using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Attribute
{
    class Program
    {
        static void Main(string[] args)
        {
            Songs song1 = new Songs("holiday", "green day" ,115);
            Songs song2 = new Songs("billy", "jean", 200);
            Console.WriteLine(song1.title);
            Console.WriteLine(Songs.songCount);
            Console.ReadLine();
        }
    }
}
