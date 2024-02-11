using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_2_
{
    class Magazine : Press
    {
        private string quality;
        public string Quality { get { return quality; } set { quality = value; } }
        public Magazine(int copies, string name, int price, string quality) : base(copies, name, price)
        {
            this.quality = quality;
        }
        new public double Cost()
        {
            if (quality == "высокое")
            {
                return base.Cost() + ((base.Cost() / 100) * 10);
            }
            else if (quality == "низкое")
            {
                return base.Cost() - ((base.Cost() / 100) * 10);
            }
            else
            {
                return Cost();
            }
        }
        public override void OutPut()
        {
            base.OutPut();
            Console.WriteLine( $"Качество: {quality}");
        }
    }
}
