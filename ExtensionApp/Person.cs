using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionApp
{
    public class Person
    {
        private static int _initalId;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public DateTime DOB { get; set; }
        public int Age
        {
            get
            {
                var _age = DateTime.Now.Year - DOB.Year;
                return _age;
            }
        }

        static Person()
        {
            _initalId = 100;
        }

        public static int Count { get; private set; }

        public Person()
        {
            _initalId++;
            Id = _initalId;
            Count++;
        }

        public Person(string name)
        {
           
            _initalId++;
            Id = _initalId;
            Name = name;
            Count++;
        }

        public override string ToString()
        {

            return "Id:" + this.Id + " Name: " + this.Name + " Surname: " + this.Surname + " Age: " + this.Age;
        }


        public void sleep()
        {
            Console.WriteLine($"{this.Name}  is sleeping");
        }
        public void eat()
        {
            Console.WriteLine($"{this.Name}  can be eat");
        }
        public static void SendMail()
        {

            Console.WriteLine("Sent mail to every one");
        }
    }
}
