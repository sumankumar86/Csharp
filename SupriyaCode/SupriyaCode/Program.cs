using System;
using System.Collections.Generic;


namespace Example
{
    class StudentDetails
    {
        private string name;
        private double sub1, sub2;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Sub1
        {
            get { return sub1; }
            set { sub1 = value; }
        }
        public double Sub2
        {
            get { return sub2; }
            set { sub2 = value; }
        }
        public override string ToString()
        {
            return ("[" + name + "," + sub1 + "," + sub2 + "," + (sub1 + sub2) + "]");
        }

    }
    class Student
    {
        public void userinput(StudentDetails e)
        {
            Console.WriteLine("Enter Name");
            e.Name = Console.ReadLine();
            Console.WriteLine("Enter Marks for 1st sub:");
            e.Sub1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Marks for 2nd sub:");
            e.Sub2 = int.Parse(Console.ReadLine());
        }
        public void display(List<StudentDetails> student)
        {
            string option = Console.ReadLine();
            switch (option)
            {
                case "Name":
                    {
                        student.Sort(delegate (StudentDetails x, StudentDetails y) {
                            return x.Name.CompareTo(y.Name);
                        });
                        break;
                    }
                case "Sub1":
                    {
                        student.Sort(delegate (StudentDetails x, StudentDetails y) {
                            return x.Sub1.CompareTo(y.Sub1);
                        });
                        break;
                    }
                case "Sub2":
                    {
                        student.Sort(delegate (StudentDetails x, StudentDetails y) {
                            return x.Sub2.CompareTo(y.Sub2);
                        });
                        break;
                    }
               
            }
            Console.WriteLine(String.Join(Environment.NewLine, student));
        }
      
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<StudentDetails> obj = new List<StudentDetails>();
            Student stobj = new Student();
            Console.WriteLine("Enter no of student:");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                obj.Add(new StudentDetails());
                stobj.userinput(obj[i]);
            }
            stobj.display(obj);
        }
    }
}