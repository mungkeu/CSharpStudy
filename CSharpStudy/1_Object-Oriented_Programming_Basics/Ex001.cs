using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy._1_Object_Oriented_Programming_Basics
{
    public class Ex001_Product
    {
        public int Code { get; private set; }
        public string Name { get; private set; }
        public int Price { get; private set; }

        public Ex001_Product(int code, string name, int price)
        {
            this.Code = code;
            this.Name = name;
            this.Price = price;
        }

        public int GetTax()
        {
            return (int)(Price * 0.08);
        }
        public int GetPriceIncludingTax()
        {
            return Price + GetTax();
        }
    }
    internal class Ex001
    {
        public void Run()
        {
            Ex001_Product yakkwa = new Ex001_Product(123, "약과", 180);
            int price = yakkwa.Price;
            int taxIncluded = yakkwa.GetPriceIncludingTax();
            Ex001_Product chapssal = new Ex001_Product(235, "찹쌀떡", 160);
        }
    }
}
