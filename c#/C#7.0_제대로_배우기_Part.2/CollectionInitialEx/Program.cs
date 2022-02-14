using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using static System.Console;

namespace CollectionInitialEx
{
    class Program
    {
        static void Main(string[] args)
        {
            // ArrayList arrayList = new ArrayList();
            /*arrayList.Add(10);
            arrayList.Add(20);*/

            // 컬렉션 초기자를 이용한 초기화 방법
            // 컬렉션 초기자는 IEnumerable 인터페이스를 상속 받아 Add()메소드를 구현하고 있다.
            // ArrayList arrayList = new ArrayList() { 10, 20, 30 };

            // 컬렉션 초기자는 Stack, Queue 에서는 사용할 수 없다.

            int[] array = { 11, 22, 33, 44 };

            ArrayList arrayList = new ArrayList(array);
            foreach (Object obj in arrayList)
                WriteLine($"ArrayList: {obj}");
            WriteLine();

            Stack stack = new Stack(array);
            foreach (Object obj in stack)
                WriteLine($"Stack: {obj}");
            WriteLine();

            Queue queue = new Queue(array);
            foreach (Object obj in queue)
                WriteLine($"Queue: {obj}");
            WriteLine();


        }
    }
}
