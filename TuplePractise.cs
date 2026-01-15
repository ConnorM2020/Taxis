using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTuples
{
    public class TuplePractise
    {
        public void Run()
        {
            // Problem 1
            var listA = new List<int> { 1, 2, 3 };  // comparing same reference type
            var listB = new List<int>(listA); // changes made via ListA, also visible via listB
                                              // so create new list with same elements as listA
            listB.Add(4);
            Console.WriteLine("Print:");
            Console.WriteLine(string.Join(", ", listA));
            Console.WriteLine(string.Join(", ", listB));
            Console.WriteLine(listA == listB);

            // Problem2
            Console.WriteLine("Problem2:");
            var point = (x: 5, y: 10);
            point.x = 20;

            Console.WriteLine(point);

            // Problem 3
            //var data = (1, 2, 3);
            //var (a, b, c) = data;   // add c in tuple

            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //Problem 4
            var nums = new List<int> { 1, 2, 3, 4 };

            for (int i = nums.Count - 1; i >= 0; i--)     // iterate back, have to loop over less each time. 
            {
                {
                    if (nums[i] % 2 == 0)
                        nums.RemoveAt(i);
                }
                Console.WriteLine(string.Join(", ", nums));
            }
            // Problem 5
            Tuple<int, int> t1 = Tuple.Create(3, 4);
            var t2 = (3, 4);

            Console.WriteLine(t1.Item1 + t2.Item1);  // 7

        }
        public void List()
        {
            List<(int Num1, int Num2, int Num3)> Values = new List<(int Num1, int Num2, int Num3)>();

            int it1 = 1;
            int it2 = 2;
            int it3 = 3;
            for (int i = 0; i < 5; i++)
            {
                Values.Add((it1, it2, it3));    // add indivudal tuple: (int Num1, int Num2, int Num3)
                it1++;
                it2++;
                it3++;
            }
            Console.WriteLine(Values);
        }
    }
}
