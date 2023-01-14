using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listobj=new List<string>() { "Suman",null,"Apu","Anik"};
            //Add
            listobj.Add("Boski");
            listobj.Add("Sunanda");
          
            foreach(var item in listobj)
            {
                Console.WriteLine(item);
            }
            //Remove
            listobj.RemoveRange(1, 1);
            foreach (var item in listobj)
            {
                Console.WriteLine(item);
            }

            listobj.ForEach(item => Console.WriteLine(item));
            string[] arr = { "ABCD", "XYZ", "VBS" };
            listobj.AddRange(arr);
            listobj.ForEach(item => Console.WriteLine(item));
        }
    }
}
