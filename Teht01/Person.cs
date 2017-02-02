using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Person
    {
        //properties
        public String Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }

        //constructor's

        public Person()
        {
        }

        public Person(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }

        //method's

        public void PersonMethod()
        {
            Console.WriteLine("This method belongs to person!");
        }

        public override string ToString()
        {
            return Firstname + " " + Lastname + " " + Address + " " + Age + " " + PhoneNumber + " ";
        }
    }
}
