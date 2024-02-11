using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_3_
{
    class Notebook
    {
        private string name;
        private int quantity;

        public string Name { get { return name; } set { name = value; } }
        public int Quantity { get { return quantity; } set { quantity = value; } }

        public Notebook(string name, int quantity)
        {
            this.name = name;
            this.quantity = quantity;
        }

        public int Cost()
        {
            return 15 * quantity;
        }
        virtual public void Print()
        {
            Console.WriteLine($"Название тетради: {name}\nКоличество листов: {quantity}");
        }

    }
}
