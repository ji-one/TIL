using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyEx2
{
    class EmployeeInfo
    {
        private string name;
        private DateTime entryDate;

        // 자동 프로퍼티 기능은 c# 3.0에서 도입된 기능
        // c#7.0부터는 자동프로퍼티에 초기값이 필요할 때 생성자에 초기화 코드를 작성해야하는 불편함을
        // 해소할 수 있도록 초기값을 바로 설정할 수 있다.

        public string Name
        {
            /*            get
                        {
                            return name;
                        }
                        set
                        {
                            name = value;
                        }*/

            get; set;
        }

        public DateTime EntryDate
        {
            /*            get
                        {
                            return entryDate;
                        }
                        set
                        {
                            entryDate = value;
                        }*/
            get; set;
        }

        public int serviceLength
        {
            get
            {
                // 1 Ticks(틱)은 100나노초 (천만분의 1초)를 나타낸다. 1밀리초는 10,000틱 
                return new DateTime(DateTime.Now.Subtract(entryDate).Ticks).Year;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeInfo employee = new EmployeeInfo();
            employee.Name = "홍길동";
            employee.EntryDate = new DateTime(2010, 10, 10);

            Console.WriteLine($"이름 : {employee.Name}");
            Console.WriteLine($"입사일 : {employee.EntryDate.ToShortDateString()}");
            Console.WriteLine($"근속년수 : {employee.serviceLength}");
        }
    }
}
