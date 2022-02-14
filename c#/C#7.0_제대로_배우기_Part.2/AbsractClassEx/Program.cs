using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsractClassEx
{
    // 추상 클래스 : 인터페이스와 비슷하다. 하지만, 추상클래스는 구현(몸통)부를 가질 수 있다.
    //              인스턴스를 가질 수는 없다

    // 추상클래스는 구현을 가질 수 있지만 인스턴스를 만들 수 없다.
    // 사용하는 한정자는 abstract와 class를 사용한다.

    /*
        선언 형식
        abstract class 클래스명
        {
            // 클래스와 동일
        }

        - 추상 클래스는 클래스와 달리 추상메소드를 갖고 있다.
        - 추상 클래스는 모든 멤버에 접근 제한자를 사용하지 않을 경우 private 설정된다.
        - 추상 메소드를 지정할 때 abstract 키워드를 사용한다.

        추상메소드의 형식
        public abstract void A();

        - 추상메소드는 private이 되면 외부에서 구현할 수 없기 때문에 public, protected, internal, protected internal 중
        하나로 수식되도록 하고 있다.
    */

    abstract class MyAbstractClass
    {
        protected void ProtectedMethod()
        {
            Console.WriteLine("추상클래스의 ProtectedMethod 호출");
        }

        public void PublicMethod()
        {
            Console.WriteLine("추상클래스의 PublicMethod 호출");
        }

        public abstract void AbstractMethod();
    }

    class Child : MyAbstractClass
    {
        public override void AbstractMethod()
        {
            Console.WriteLine("추상클래스의 AbstractMethod 호출");
            ProtectedMethod();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyAbstractClass myabs = new Child();
            myabs.AbstractMethod();
            myabs.PublicMethod();
        }
    }
}
