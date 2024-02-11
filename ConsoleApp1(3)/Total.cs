using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_3_
{
    class Total:Notebook
    {
        private string material;

        public string Material { get { return material; } set { material = value; } }
        
        public Total(string name, int quantity,string material):base(name, quantity)
        {
            this.material = material;
        }
        new public int Cost()
        {
            return base.Cost() + 50;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Материал обложки: {material}");
        }
    }
}
