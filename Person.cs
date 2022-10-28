using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

namespace Undervisning271022
{
    internal class Person
    {
        //public internal protected private
        internal string Name  { get; private set; }
        private int Age { get; set; }
        public string Place { get; set; }
        public int ID { get; set; }
        public static int staticNumber { get; set; }
        public int Number { get; set; }
        public PhoneNumber PhoneNumber { get; set; }
        public List<int> listeMedTall; 
        public Person(string name, int age, string place, PhoneNumber phoneNumber)
        {
            Name = name;
            Age = age;
            Place = place;
            ID = 10;
            PhoneNumber = phoneNumber;
            PhoneNumber = new PhoneNumber(1244356);
            listeMedTall = new List<int>();

        }

        public Person()
        {
        }

        public static void addStaticNumber()
        {
            staticNumber++;
        }
        public void addNumber()
        {
            Number++;
        }

        public void printNumbers()
        {
            Console.WriteLine("Static Number: " + staticNumber);
            Console.WriteLine("Number: " + Number);
        }

        public void setName(string name)
        {
            Name = name;
        }

        private int getAge()
        {
            return Age;
        }
        public void printInfo()
        {
            Console.WriteLine(getAge());
            
            //Name = "Joakim";
            Console.WriteLine("Mitt navn er: " + Name + " Jeg er " + Age + " år gammel " + "Jeg bor i " + Place);
        }

    }

   
}
