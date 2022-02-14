using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticEx
{
    class Program
    {
        static void Main(string[] args)
        {
            // static(정적) 메소드와 정적 필드 
            // 한 프로그램 안에 클래스는 하나만 존재하지만 인스턴스는 여러개가 존재할 수 있다.
            // 한 프로그램 안에 똑같은 클래스는 두개가 존재할 수 없다.

            // static 필드나 static 메소드는 클래스에 소속된 것이므로 프로그램 안에 유일하게 존재한다는 의미

            DemoClass demoClass = new DemoClass();
            demoClass.a = 100;
            demoClass.b = 200;

            DemoClass democlass2 = new DemoClass();
            democlass2.a = 1;
            democlass2.b = 2;

            SdemoClass.a = 11; // 인스턴스 생성 안함
            SdemoClass.b = 22;
        }
    }
    class DemoClass
    {
        public int a;
        public int b;
    }

    class SdemoClass
    {
        public static int a;
        public static int b;
    }
}
