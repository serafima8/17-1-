using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Press> press = new List<Press>();
            press.Add(new Press(2, "Юность", 150));
            List<Magazine> magazines = new List<Magazine>();
            magazines.Add(new Magazine(3,"Космос",200,"высокое"));
            foreach(var pr in press )
            {
                pr.OutPut();
                Console.WriteLine($"Стоимость тиража:{pr.Cost()}");
            }
            foreach (var mg in magazines)
            {
                mg.OutPut();
                Console.WriteLine($"Стоимость тиража:{mg.Cost()}");
            }
            Console.ReadKey();
        }
    }
}
