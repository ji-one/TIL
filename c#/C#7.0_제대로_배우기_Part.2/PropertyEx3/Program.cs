using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyEx3
{
    // c# 7.0에서 도입된 자동 프로퍼티 초기화 사용하기
    
    class EmployeeInfo
    {
        public string Name { get; set; } = "아무나";
        public DateTime EntryDate { get; set; } = new DateTime(2000, 1, 1);
        public int ServiceLength
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(EntryDate).Ticks).Year;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /* 객체를 생성할 때 객체의 필드를 초기화하는 다른 방법
                
                - 선언방법
                클래스명 인스턴스명 = new 클래스명()
                {
                    프로퍼티1이름 = 값,
                    프로퍼티2이름 = 값,
                    ...
                };
            */
            EmployeeInfo employee = new EmployeeInfo()
            {
                Name = "홍길동",
                EntryDate = new DateTime(2011, 10, 11)
            };

            Console.WriteLine($"이름 : {employee.Name}");
            Console.WriteLine($"입사일 : {employee.EntryDate.ToShortDateString()}");
            Console.WriteLine($"근속년수 : {employee.ServiceLength}");

            /*            EmployeeInfo employee = new EmployeeInfo();
                        Console.WriteLine($"이름 : {employee.Name}");
                        Console.WriteLine($"입사일 : {employee.EntryDate.ToShortDateString()}");
                        Console.WriteLine($"근속년수 : {employee.ServiceLength}");

                        employee.Name = "고길동";
                        employee.EntryDate = new DateTime(2005, 5, 25);

                        Console.WriteLine($"이름 : {employee.Name}");
                        Console.WriteLine($"입사일 : {employee.EntryDate.ToShortDateString()}");
                        Console.WriteLine($"근속년수 : {employee.ServiceLength}");*/
        }
    }
}
