using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassConversionEx
{
    // 상속관계의 클래스 사이에서의 형변환
    class Human
    {
        public void showInfo()
        {
            Console.WriteLine("Human");
        }
    }

    class Programmer : Human
    {
        public void programming()
        {
            Console.WriteLine("프로그래밍하는 개발자");
        }
    }

    class Designer : Human
    {
        public void design()
        {
            Console.WriteLine("디자인하는 디자이너");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.showInfo();

            // Programmer programmer = new Programmer();
            // programmer.showInfo();
            // programmer.programming();


            // Designer designer = new Designer();
            // designer.showInfo();
            // designer.design();

            human = new Programmer();
            // human.programming(); // 불가능
            human.showInfo();

            Programmer programmer = (Programmer)human; // 자식의 형태로 변형 가능
            programmer.showInfo();
            programmer.programming();

            human = new Designer();
            human.showInfo();

            Designer designer = (Designer)human;
            designer.showInfo();
            designer.design();

        }
    }
}
