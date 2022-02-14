using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideEx
{
    // override : 메소드 재정의

    // virtual : 부모(base)클래스 메소드 앞에 붙는 키워드
    // 자식(파생: derived)클래스에 의해서 재정의 될 수 있다는 의미를 가짐

    // override : 자식(derived)클래스 메소드 앞에 붙는 키워드
    // 부모로부터 받은 메소드를 재정의 한다라는 의미
    // 재정의 할 때는 부모의 메소드 이름과 같아야 함. 프로토타입도 일치해야함

    // new : 오버라이딩과는 다른 개념으로 메소드를 숨기는 기능

    class BaseClass
    {
        public virtual void echo()
        {
            Console.WriteLine("기반 클래스");
        }
    }

    class DerivedClass : BaseClass
    {
        public override void echo()
        {
            Console.WriteLine("파생 클래스");
        }

        public void test()
        {
            Console.WriteLine("test");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.echo();

            BaseClass baseClass = new DerivedClass();
            baseClass.echo(); // 파생 클래스
        }
    }
}
