using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashtableInitialEx
{
    // Hashtable 초기화할 때 딕셔너리 초기자 (Dictionary Initializer)를 이용할 수 있다.
    class Program
    {
        static void Main(string[] args)
        {
            /*Hashtable ht = new Hashtable()
            {
                ["seoul"] = "서울",
                ["incheon"] = "인천",
                ["kwangju"] = "광주"
            };*/

            Hashtable ht = new Hashtable()
            {
                {"seoul", "서울" },
                {"incheon", "인천" }
            };

            Console.WriteLine(ht["seoul"]);
        }
    }
}
