using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleEx
{
    // Tuple(튜플) : 여러개의 필드를 담을 수 있는 구조체와 비슷한 것
    //               c# 7.0 이전 버전에서는 메소드에서 하나의 값만을 리턴할 수 있었지만, 이후 버전에서는
    //               튜플을 이용해서 복수 개의 값들을 리턴할 수 있게 되었다.

    // 튜플 선언 예
    // var t = (100, 200) --> Unnamed Tuple
    // 튜플은 ( ) 안에 여러개의 필드를 지정하여 만들 수 있다.

    // var t = (Name: "홍길동", Id: "1212") --> 필드가 정의된 튜플 Named Tuple
    class Program
    {
        static void Main(string[] args)
        {
            var aa = ("홍길동", 40);
            Console.WriteLine($"{aa.Item1}, {aa.Item2}");

            var bb = (Name: "홍길북", Age: 55);
            Console.WriteLine($"{bb.Name}, {bb.Age}");

            var (name, age) = bb;
            Console.WriteLine($"{name}, {age}");

            bb = aa;
            Console.WriteLine($"{bb.Name}, {bb.Age}");
        }
    }
}
