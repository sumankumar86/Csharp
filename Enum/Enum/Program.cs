using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    public enum district
    {
        Kolkata,
        burdwan,
        Mednipur,
        Howrah
    }
    internal class Program
    {
        enum person
        {
            Suman=10,
            Anik,
            Apu,
            Boski,
            Sriti
        }
        static void Main(string[] args)
        {
            int value = (int)district.burdwan;
            Console.WriteLine(value);
            Console.WriteLine(district.Kolkata);
            Console.WriteLine((int)person.Anik);
        }
    }
}
