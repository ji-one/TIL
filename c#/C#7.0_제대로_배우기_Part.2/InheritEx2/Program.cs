using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritEx2
{
    // 기반(부모) 클래스의 인자 생성자에 파생(자식) 클래스가 인자를 전달하는 방법
    // base 키워드는 기반 클래스를 가리키는 키워드이다. 따라서, 기반 클래스의 멤버를 접근할 때 사용할 수 있다.
    // sealed 키워드(한정자)를 이용하면 상속을 봉인하게 되어 상속이 불가능하도록 클래스를 선언하는 방법이다.
    class Parent
    {
        protected string name;
        public Parent(string name)
        {
            this.name = name;
            Console.WriteLine($"{this.name}.Parent() 생성자 호출");
        }

        ~Parent()
        {
            Console.WriteLine($"{this.name}.~Parent() 종료자 호출");
        }

        public void ParentMethod()
        {
            Console.WriteLine($"{name}.ParentMethod()");
        }
    }

    class Child : Parent
    {
        public Child(string name) : base(name)
        {
            Console.WriteLine($"{this.name}.Child() 생성자 호출");
        }

        ~Child()
        {
            Console.WriteLine($"{this.name}.~Child() 종료자 호출");
        }

        public void ChildMethod()
        {
            // Console.WriteLine($"{name}.ChildMethod()");
            base.ParentMethod();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Parent parentA = new Parent("parentA");
            parentA.ParentMethod();

            Child childA = new Child("childA");
            childA.ParentMethod();
            childA.ChildMethod();
        }
    }
}
