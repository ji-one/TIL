using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyEx
{
    // 프로퍼티
    /*
        선언 형식

        데이터타입 필드명;
        접근제한자 데이터타입 프로퍼티명
        {
            get
            {
                return 필드명
             }
            set
            {
                필드명 = value
            }
        }

        - value는 키워드임.
        - get, set은 접근자 (accessor)

    */
    
    class DemoClass
    {
        /*        private int demoField;

                public int GetDemoField()
                {
                    return demoField;
                }

                public void SetDemoField(int Value)
                {
                    demoField = Value;
                }*/

        private int demoField;
        public int DemoField
        {
            get
            {
                return demoField;
            }
            set
            {
                demoField = value;
            }
        }

        // 프로퍼티를 읽기전용(get접근자만 구현했을 때),
        // 쓰기전용(set접근자만 구현했을 때)으로 정의할 수 있다.
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*            DemoClass demoClass = new DemoClass();
                        demoClass.SetDemoField(100);
                        Console.WriteLine(demoClass.GetDemoField());*/

            DemoClass demoClass = new DemoClass();
            demoClass.DemoField = 10;
            Console.WriteLine(demoClass.DemoField);
        }
    }
}
