using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to morningstar");
            
            Person person=new Person();
            person.FirstName = "Rahul";
            person.LastName = "Badwar";
            Console.WriteLine(person.FirstName+" "+person.LastName);

            Console.ReadLine();

        }
    }
}
