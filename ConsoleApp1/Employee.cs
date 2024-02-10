using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee : Person
    {
        private string company;

        private string job;
        public string Company { get { return company; } set { company = value; } }
        public string Job { get { return job; } set { job = value; } }
        public Employee(int age, string name, string surname, string company, string job) : base(age, name, surname)
        {
            this.company = company;
            this.job = job;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Компания: {company}\nРабота: {job}");
        }
    }
}
