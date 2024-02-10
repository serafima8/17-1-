using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student : Person
    {
        private DateTime birth;
        private int course;

        public DateTime Birth { get { return birth; } set { birth = value; } }
        public int Course { get { return course; } set { course = value; } }

        public Student(int age, string name, string sername, DateTime birth, int course) : base(age, name, sername)
        {
            this.birth = birth;
            this.course = course;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Дата рождения: {birth}\nКурс обучения: {course}");
        }
    }
}
