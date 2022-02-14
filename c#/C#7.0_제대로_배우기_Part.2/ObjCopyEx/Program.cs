using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjCopyEx
{
    class Program
    {
        class Demo1
        {
            public int aa;
            public int bb;
            public Demo1 DeepCopy()
            {
                Demo1 newDemo1 = new Demo1();
                newDemo1.aa = this.aa;
                newDemo1.bb = this.bb;

                return newDemo1;
            }
        }
        static void Main(string[] args)
        {
            {
                // 얕은 복사
                Demo1 demo1 = new Demo1();
                demo1.aa = 100;
                demo1.bb = 1000;

                Demo1 demo11 = demo1;
                demo11.bb = 1111;
                Console.WriteLine("---------- 얕은 복사(Shallow Copy) ----------");
                Console.WriteLine($"{demo1.aa} {demo1.bb}"); // 100 1111
                Console.WriteLine($"{demo11.aa} {demo11.bb}"); // 100 1111
            }

            // 깊은 복사
            {
                Demo1 demo1 = new Demo1();
                demo1.aa = 100;
                demo1.bb = 1000;

                Demo1 demo11 = demo1.DeepCopy();
                demo11.bb = 1111;
                Console.WriteLine("---------- 깊은 복사(Deep Copy) ----------");
                Console.WriteLine($"{demo1.aa} {demo1.bb}");
                Console.WriteLine($"{demo11.aa} {demo11.bb}");
            }

        }
    }
}
