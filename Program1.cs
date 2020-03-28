using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_3._1
{
    /* Дан список чисел. Порахуйте, скільки в ньому пар елементів, 
    рівних один одному. Вважається, що будь-які два елементи,
    рівні один одному, утворюють одну пару, яку необхідно порахувати.*/
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 0,1,  5, 1,  6, 1, 1, 1, 1 };
            Console.WriteLine("We have a list of numbers : " );
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            numbers.Sort(); 
            int k = AmounOfPairs(numbers);
            Console.WriteLine();
            Console.WriteLine("The number of pairs of elements equal to each other is : " +  k);
            Console.ReadKey();
        }
        static int AmounOfPairs(List<int> numbers)
        {
            int count = 0;
            for (int i = 0; i < numbers.Count - 1;)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    count++;
                    i += 2;
                }
                else
                {
                    i++;
                }
            }
            return count;
        }
    }
}
   
