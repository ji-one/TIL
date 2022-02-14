using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritEx
{
    class Parent  
    {
        public Parent()
        {
            Console.WriteLine("Parent() 생성자 호출");
        }
        ~Parent()
        {
            Console.WriteLine("~Parent()  종료자 호출");
        }
        public void showInfo()
        {
            Console.WriteLine("Parent Class");
        }
    }

    class Child : Parent
    {
        public Child()
        {
            Console.WriteLine("Child() 생성자 호출");
        }

        ~Child()
        {
            Console.WriteLine("~Child() 종료자 호출");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 상속
            Child child = new Child();
            child.showInfo();

            /**
             * output:
             * Parent() 생성자 호출
             * Child() 생성자 호출
             * Parent Class
             * ~Child() 종료자 호출
             * ~Parent()  종료자 호출
             */
        }
    }
}
