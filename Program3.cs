using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    /*
     * Дана послідовність цілих чисел. 
     * Витягти з неї всі непарні числа,
     * зберігши їх вихідний порядок проходження і видаливши всі 
     * входження повторюваних елементів, крім перших. (2)
     */
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = {-5, -4, -2, 1, 4, 5, 6 , 1, -2, -7};
            Console.WriteLine("This sequence of integers : ");
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write(mass[i] + "  ");
            }
            IEnumerable<int> odd = from i in mass
                               where i%2!=0
                               select i;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("All odd numbers : ");
            foreach (int i in odd)
                Console.Write(i + "  ");
            IEnumerable<int> distinctnumbers = odd.Distinct();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("All distinct numbers : ");
            foreach (int i in distinctnumbers)
                Console.Write(i + "  ");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
