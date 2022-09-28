using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy._1_Object_Oriented_Programming_Basics
{
    // 클래스 참조형
    class Ex002ClassPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    // 구조체 값형
    struct Ex002StructPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
        
        public Ex002StructPoint(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
    internal class Ex002
    {
        public void Run()
        {
            // c#에 정의되어 있는 구조체
            DateTime date = new DateTime(2022, 9, 28);
            int year = date.Year;
            DateTime daysAfter10 = date.AddDays(10); // 10일 후 

            // 구조체 테스트
            Ex002StructPoint a = new Ex002StructPoint(10, 20);
            Ex002StructPoint b = a;
            Console.WriteLine("a:({0},{1})",a.X,a.Y);
            Console.WriteLine("b:({0},{1})", b.X, b.Y);
            a.X = 80;
            Console.WriteLine("a:({0},{1})", a.X, a.Y);
            Console.WriteLine("b:({0},{1})", b.X, b.Y);
        }
    }
}
