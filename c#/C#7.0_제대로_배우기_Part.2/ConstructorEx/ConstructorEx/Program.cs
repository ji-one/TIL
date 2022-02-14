using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorEx
{
    class Program
    {
        static void Main(string[] args)
        {
            // 생성자 (Constructor) : 설계된 클래스의 객체를 생성하는 메소드와 같은 것
            // 생성자 형식
            // 한정자 클래스명 (매개변수명)
            // {
            //      ~
            // } 

            // 클래스를 선언할 때 생성자를 구현하지 않았을 경우에는 컴파일러에서 기본생성자를 만들어준다.

            Person person = new Person();
            person.name = "홍길동";
            person.gender = "남";

            Person person2 = new Person("홍길순", "여");
            Console.WriteLine(person2.name);
        }
    }

    class Person
    {
        public string name;
        public string gender;

        public Person() // 기본 생성자, 생성자의 이름은 클래스의 이름과 같다.
        {
            name = "";
            gender = "";
        }

        public Person(string _name, string _gender) // 생성자는 반환 타입이 없음
        {
            name = _name;
            gender = _gender;
        }

        // 종료자 : 클래스의 이름에 ~를 붙여서 사용한다.
        //          생성자와 달리 한정자도 사용하지 않고, 매개변수도 없고 오버로딩도 불가능하다.
        //          직접 호출 할 수 없다.
        //          CLR의 가비지 컬렉터가 객체가 소멸되는 시점을 판단해서 종료자를 호출한다.

        // CLR (Common Language Runtime) 
        // JIT compile을 CLR이 해줌

        ~Person()
        {
            // C# 6.0에서는 문자열 포맷팅을 할 때 $ 기호를 이용하여 표현할 수 있도록 하고 있다.
            // Console.WriteLine("{0}님 다음에 뵈어요", name); 대신에
            Console.WriteLine($"{name}님 다음에 뵈어요");
        }

        public void greet()
        {
            Console.WriteLine("hello, I'm {0}", name);
        }
    }
}
