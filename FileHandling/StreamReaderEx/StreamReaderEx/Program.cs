using System;
using System.IO;


namespace StreamReaderEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream obj=new FileStream("C:\\Training\\C# Revision\\FileHandling\\File Read Write\\streamwriter.txt",FileMode.Open,FileAccess.Read);
            StreamReader sr=new StreamReader(obj);

            string line = "";
            while((line=sr.ReadLine())!=null)
            {
                Console.WriteLine(line);
            }

            TextReader tr = File.OpenText("C:\\Training\\C# Revision\\FileHandling\\File Read Write\\streamwriter.txt");
            Console.WriteLine(tr.ReadLine());
            //Console.WriteLine(tr.ReadToEnd());

            
            sr.Close();
            
            obj.Close();
        }
    }
}
