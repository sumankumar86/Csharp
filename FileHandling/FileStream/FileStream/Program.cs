using System;
using System.IO;


namespace FileStreamEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream obj = new FileStream("C:\\Training\\C# Revision\\FileHandling\\File Read Write\\exmple.txt",FileMode.OpenOrCreate);
            //obj.WriteByte(65);
/*
            for(int i = 65; i <= 90; i++)
            {
               
                obj.WriteByte((byte)i);
            }
            obj.Close();*/
            
            //Read Data
            int i=0;
            while ((i = obj.ReadByte()) != -1)
            {
                Console.WriteLine((char)i);
            }
            
        }
    }
}
