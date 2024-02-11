using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Notebook> notebooks = new List<Notebook>();
            notebooks.Add(new Notebook("Предметная", 96));
            List<Total> totals = new List<Total>();
            totals.Add(new Total("Стандартная", 12, "плотная бумага"));
            foreach(var ntb in notebooks)
            {
                ntb.Print();
                Console.WriteLine($"Стоимость: {ntb.Cost()}");
            }
            foreach (var ttl in totals)
            {
                ttl.Print();
                Console.WriteLine($"Стоимость: {ttl.Cost()}");
            }
            Console.ReadKey();
        }
    }
}
