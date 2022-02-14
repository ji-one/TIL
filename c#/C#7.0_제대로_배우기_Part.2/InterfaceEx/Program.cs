using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 인터페이스 선언
    interface 인터페이스명
    {
        반환형식 메소드명(매개변수, ..);
        .... 
    }

    - 인터페이스는 필드를 포함하지 않는다. (이벤트, 메소드, 프로퍼티만을 멤버로 갖는다.)
    - 인터페이스의 모든 멤버는 public 접근 권한으로 지정된다. 따라서, 접근 제한자를 사용할 수 없다.
    - 인터페이스는 구현부(몸통)가 없는 추상멤버를 갖는다.
    - 인터페이스는 다중 상속이 가능하다. 인터페이스는 다른 인터페이스를 상속 받을 수 있다.
        클래스에서도 인터페이스를 상속받을 수 있고, 구조체에서도 인터페이스를 상속받을 수 있다.
    - 인터페이스는 인스턴스를 만들 수 없다.
    - 
*/

namespace InterfaceEx
{
    interface IMyInterfaceA
    {
        void output();
    }

    interface IMyInterfaceB
    {
        void output();
    }

    class MyClass : IMyInterfaceA, IMyInterfaceB
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            IMyInterfaceA iA = myClass;
            iA.output();

            IMyInterfaceB iB = myClass;
            iB.output();
        }

        void IMyInterfaceA.output()
        {
            Console.WriteLine("A인터페이스 output() 호출");
        }

        void IMyInterfaceB.output()
        {
            Console.WriteLine("B인터페이스 output() 호출");
        }
    }
}
