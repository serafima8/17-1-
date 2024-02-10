using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {
        private int age;
        private string name;
        private string surname;
        public int Age { get { return age; } set { age = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Surname { get { return surname; } set { surname = value; } }
        public Person() {  }
        public Person(int age)
        {
            this.age = age;
        }

        public Person(int age, string name) : this(age)
        {
            this.name = name;
        }
        public Person(int age, string name, string surname) : this(age, name)
        {
            this.surname = surname;
        }

        virtual public void Print()
        {
            Console.WriteLine($"Возраст: {age}\nИмя: {name}\nФамилия: {surname}");
        }
    }
}
