using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            persons.Add(new Person(17, "Михаил", "Рубцов"));
            persons.Add(new Employee(17, "Николай", "Коваленко", "EXE", "Программист"));
            persons.Add(new Student(18, "Кристина", "Ломаносова", new DateTime(2006, 6, 12), 3));
            foreach (var st in persons)
            {
                st.Print();
            }


            Console.ReadKey();

        }
    }
}
