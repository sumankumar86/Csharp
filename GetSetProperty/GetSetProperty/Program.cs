using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetProperty
{
    class Details
    {
        private int id;
        private double salary;
        private string name;
        private string desgn;
        public int Id
        {
            get { return id; }
            set {
                if (id > 0)
                {
                    id= value;
                }
                }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Desgn
        {
            get { return desgn; }
            set { desgn = value; }
        }  
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

    }

    class Emp
    {
        public void userinput(Details d)
        {
            Console.WriteLine("Enter id:");
            d.Id=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name:");
            d.Name=Console.ReadLine();
            Console.WriteLine("Enter Designation:");
            d.Desgn=Console.ReadLine();
            Console.WriteLine("Enter Salary:");
            d.Salary=double.Parse(Console.ReadLine());
        }
        public void display(Details d)
        {
            Console.WriteLine("Id:{0}",d.Id);
            Console.WriteLine("Name:{0}",d.Name);
            Console.WriteLine("Designation:{0}",d.Desgn);
            Console.WriteLine("Salary:{0}",d.Salary);
         
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no of employee:");
            int noemp = int.Parse(Console.ReadLine());
            var obj = new List<Details>(noemp);
            Emp emp = new Emp();
        
            for(int i= 0;i<noemp;i++)
            {
               
                obj.Add(new Details());
                emp.userinput(obj[i]);
            }
            foreach(var d in obj)
            {
                emp.display(d);
            }
        }
    }
}
