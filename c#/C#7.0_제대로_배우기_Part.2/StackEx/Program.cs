using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace StackEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            stack.Push(100);
            stack.Push(11);
            stack.Pop();
            stack.Push("문자열");

            while (stack.Count > 0)
                Console.WriteLine(stack.Pop());
        }
    }
}
