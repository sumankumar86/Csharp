using System;
using System.IO;

namespace BinaryWriterex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryWriter bw= new BinaryWriter(File.Open("C:\\Training\\C# Revision\\FileHandling\\File Read Write\\BinaryWrite.dat",FileMode.Create));
            bw.Write("This is string");
            bw.Write(true);
            bw.Write(20);
            bw.Write(20.5);

            bw.Close();
            Console.WriteLine("Binary Writer created success");
            Program.read();
        }
        public static void read()
        {
            BinaryReader obj = new BinaryReader(File.Open("C:\\Training\\C# Revision\\FileHandling\\File Read Write\\BinaryWrite.dat", FileMode.Open));

            Console.WriteLine("String:{0}", obj.ReadString());
            Console.WriteLine("Double:{0}", obj.ReadDouble());
            Console.WriteLine("Integer:{0}", obj.ReadInt16());
            Console.WriteLine("Boolean:{0}", obj.ReadBoolean());
        }
    }
}
