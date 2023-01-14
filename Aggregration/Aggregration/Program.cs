using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregration
{
    class Details
    {
        public string addressline;
        public int pin;
        public Details(string addressline,int pin)
        {
            this.addressline = addressline;
            this.pin = pin;
        }
    }
    class Employee
    {
        private string name;
        private Details address;

        public Employee(string name,Details address)
        {
            this.name = name;
            this.address = address;
        }
        public void display()
        {
            Console.WriteLine($"Name is {name} and address is {address.addressline} and pin is {address.pin}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Details det = new Details("Kolkata", 713121);
            Employee obj = new Employee("Suman", det);
            obj.display();
        }
    }
}
