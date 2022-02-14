using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace QueueEx
{
    // Queue : FIFO
    //  - Enqueue : 데이터를 입력
    //  - Dequeue : 데이터 출력

    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();

            q.Enqueue(1);
            q.Enqueue(100);
            q.Enqueue(200);
            q.Dequeue();
            q.Enqueue(22.5);
            // int aa = (int)q.Dequeue();
            q.Dequeue();
            q.Enqueue("가나다");

            while (q.Count > 0)
                Console.WriteLine(q.Dequeue());
        }
    }
}
