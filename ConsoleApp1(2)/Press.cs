using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_2_
{
    class Press
    {
        private int copies;
        private string name;
        private int price;

        public int Copies { get { return copies; } set { copies = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int Price { get { return price; } set { price = value; } }

        public Press(int copies, string name, int price)
        {
            this.copies = copies;
            this.name = name;
            this.price = price;
        }
        public double Cost()
        {
            return price * copies;
        }

        virtual public void OutPut()
        {
            Console.WriteLine($"Количество копий: {copies}\nНазвание: {name}\nЦена: {price}\n");
        }
    }
}
