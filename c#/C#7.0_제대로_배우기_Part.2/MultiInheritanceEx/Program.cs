using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiInheritanceEx
{
    /*    class A
        {
            public void Output()
            {
                Console.WriteLine("A의 출력");
            }
        }

        class B
        {
            public void Output()
            {
                Console.WriteLine("B의 출력");
            }
        }*/

    interface Ia // 인터페이스명에 보통 I 붙여줌
    {
        void output();
    }
    
    interface Ib
    {
        void print();
    }

    class MyClass : Ia, Ib
    {
        public void output()
        {
            Console.WriteLine("A 인터페이스 출력");
        }

        public void print()
        {
            Console.WriteLine("B 인터페이스 출력");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            mc.output();
            mc.print();

            Ia ia = mc as Ia;
            ia.output();

            Ib ib = mc as Ib;
            ib.print();
        }
    }
}
