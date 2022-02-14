
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructEx
{
    // c#에서는 struct를 사용하면 value type을 만들고, class 사용하면 reference type
    // int, doubl, float, bool 타입들을 기본타입(primitive type)이라고 하는데, struct로 정의된 value type이다
    // value type은 상속할 수 없으며, 주로 간단한 데이터 값을 저장하는데 사용된다.

    // reference type은 class를 정의해서 만들고, 상속이 가능하고, 좀 더 복잡한 데이터와 기능들을 정의하는 곳에 많이 사용

    // 구조체 : struct라는 키워드를 이용해서 정의. 클래스와 같이 메소드, 속성(프로퍼티)등 거의 비슷한 구조를 갖고 있지만, 상속을 할 수 없다.
    //          클래스와 마찬가지로 인터페이스(interface) 구현을 할 수 있다.

    // ** 구조체는 클래스와 달리 복사를 할 때 DeepCopy가 이루어짐


    // 구조체 정의하기
    struct MyPoint
    {
        public int X;
        public int Y;

        // 구조체는 매개변수가 없는 생성자는 선언할 수 없다.
        public MyPoint(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        // 모든 구조체는 System.Object 형식을 상속하는 System.ValueType으로부터 직접 상속받음
        public override string ToString()
        {
            return string.Format($"{X}, {Y}");
        }


    }
    class Program
    {

        static void Main(string[] args)
        {
            MyPoint myPoint;
            myPoint.X = 100;
            myPoint.Y = 100;
            Console.WriteLine(myPoint.ToString());

            MyPoint myPoint2 = new MyPoint(1000, 1000);
            MyPoint myPoint3 = myPoint2; // deep copy
            myPoint3.Y = 1001;

            Console.WriteLine(myPoint2.ToString()); // 1000, 1000
            Console.WriteLine(myPoint3.ToString()); // 1000, 1001

        }
    }
}
