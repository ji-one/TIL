using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            (int count, int sum, double average) GetScore(List<int> data) // 튜플 리턴 타입
            {
                int cnt = 0, sum = 0;
                double avg = 0;

                foreach(var i in data)
                {
                    cnt++;
                    sum += i;
                }

                avg = sum / cnt;
                return (cnt, sum, avg);
            }

            var scoreList = new List<int> { 10, 11, 22, 33, 44 };
            var result = GetScore(scoreList);

            Console.WriteLine($"{result.count}, {result.sum}, {result.average}");
            Console.WriteLine($"{result.Item1}, {result.Item2}, {result.Item3}");
        }
    }
}
