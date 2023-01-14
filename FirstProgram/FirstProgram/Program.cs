using System;
using System.Linq;

namespace FirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size");
            int size = int.Parse(Console.ReadLine());
            string[] name =new string[size]; 
    

            for(int i = 0; i < name.Length; i++)
            {
                Console.WriteLine("Enter name:");
                name[i] = Console.ReadLine();
            }
            foreach(string item in name)
            {
                Console.WriteLine(item);
            }
        
            Array.Sort(name);
            string[] newname = name;
            foreach(var item in newname)
            {
                Console.WriteLine(item);
            }

            int[]arr=new int[] {1,2,10,20};
            int[] arr1 = { 10, 20, 50, 60 };

            Console.WriteLine("Enter Name for Search");
            string sname = Console.ReadLine();
            int temp = 0;
            foreach(var item in newname)
            {
                if (item.CompareTo(sname) == 0)
                {
                    Console.WriteLine("Find");
                    temp = 1;
                }
          
              
            }
            if (temp == 0)
            {
                Console.WriteLine("Not Find");
            }
            
  

            Console.ReadKey();
        }
    }
}
