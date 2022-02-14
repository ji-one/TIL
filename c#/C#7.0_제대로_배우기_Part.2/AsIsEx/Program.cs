using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsIsEx
{
    class Human
    {
        public void showInfo()
        {
            Console.WriteLine("Human");
        }

    }

    class Programmer : Human
    {
        public void programming()
        {
            Console.WriteLine("코딩하는 프로그래머");
        }
    }

    class Designer : Human
    {
        public void design()
        {
            Console.WriteLine("디자인하는 디자이너");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // as is 연산자

            // as : 형변환(캐스팅)과 같은 역할을 하는 연산자. 형변환에 실패했을 경우에는 null 값을 리턴
            // is : 해당 객체의 Type(형)이 일치하는지 여부를 bool 값으로 변환하는 연산자

            Human human = new Programmer();
            Programmer programmer;

            if(human is Programmer)
            {
                programmer = (Programmer)human;
                programmer.programming();
            }

            Human human2 = new Designer();

            Designer designer = human2 as Designer;
            if(designer != null)
                designer.design();

            Designer designer2 = human as Designer; // 상속 관계가 아님
            if (designer2 != null)
                designer2.design();
            else
                Console.WriteLine("designer2는 Designer 형이 아니다.");

        }
    }
}
