using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayListEx
{
    /*
        Collection(컬렉션) : 간단히 말하면, 데이터 모음을 담는 자료구조
        배열이나 스택, 큐 등을 C#에서는 컬렉션이라는 이름으로 제공
    
        .Net 프레임워크에서 사용하는 컬렉션은 ICollection 인터페이스를 상속받는다.
        배열은 System.Array 타입이다.
        System.Array는 Icollection 인터페이스를 상속 받기 때문에
        배열은 컬렉션의 일부이다.
        
        - ArrayList, Queue, Stack, HashTable
        
        # ArrayList는 배열과 비슷한 컬렉션
        배열처럼 [] 인덱스로 요소의 접근이 가능하고, 특정 요소를 바로 읽고 쓸 수 있다.
        하지만, 배열을 선언할 때는 배열의 크기를 지정하는 반면에 ArrayList는 크기를 지정하지 않는다.
        요소의 추가, 삭제에 따라서 자동으로 크기를 늘였다 줄였다 한다.

        또한, ArrayList 컬렉션은 모든 타입의 변수를 담을 수 있다.
        (C#에서 제공하는모든 컬렉션은 모든 타입의 변수를 담을 수 있다. 그 이유는 컬렉션의 요소둘은 object 타입으로 저장되기 때문)
    */
    class Program
    {
        static void Main(string[] args)
        {
            /*          int[] array = new int[] { 1, 2, 3, 4, 5 };
                        Console.WriteLine($"배열의 타입 : {array.GetType()}");
                        Console.WriteLine($"배열의 기본 타입 : {array.GetType().BaseType}");
            */

            ArrayList arrayList = new ArrayList();

            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add(100);

            // RemoveAt(index) 리스트의 해당 인덱스를 찾아 제거
            // Revmove(data) 매개변수로 전달된 data를 찾아서 제거
            arrayList.RemoveAt(1); // arrayList.Remove(2) <- 실제 들어있는 요소의 값을 지움

            // insert(index, data) index 위치에 data를 삽입
            arrayList.Insert(1, 2.2f);
            arrayList.Add("ABC");
            arrayList.Add("가나다");

            // 컬렉션의 모든 요소들은 object 타입이기 때문에 foreach문에서 object obj가 가능하다
            foreach(object obj in arrayList)
            {
                Console.Write($"{obj} ");
            }
        }
    }
}
