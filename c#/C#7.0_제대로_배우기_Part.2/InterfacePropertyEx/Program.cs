using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePropertyEx
{
    // 인터페이스에서 프로퍼티
    interface IKeyValue
    {
        // 인터페이스에서 자동 프로퍼티는 c# 컴파일러가 자동으로 구현해주지 않는다.
        // 따라서, 해당 인터페이스를 상속받는 클래스에서 구현해주어야 한다.
        string Key
        {
            get; set;
        }

        string Value
        {
            get; set;
        }
    }

    class KeyValue : IKeyValue
    {
        // IKeyValue의 인터페스를 구현해주고 있음 (즉, 컴파일러가 자동으로 프로퍼티 구현을 해줌)
        public string Key
        {
            get; set;
        }

        public String Value
        {
            get; set;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            KeyValue school = new KeyValue()
            { 
                Key = "초등학교",
                Value = "산천"
            };

            KeyValue address = new KeyValue()
            {
                Key = "주소",
                Value = "서울 강서구"
            };

            Console.WriteLine($"{school.Key} : {school.Value}");
            
        }
    }
}
