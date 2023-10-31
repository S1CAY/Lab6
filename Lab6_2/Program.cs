using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_2
{
    public delegate bool Criteria<T>(T item);

    class Program
    {
        static void Main(string[] args)
        {
            Repository<int> intRepository = new Repository<int>();
            Repository<string> stringRepository = new Repository<string>();

            intRepository.Add(1);
            intRepository.Add(2);
            intRepository.Add(3);
            intRepository.Add(4);
            intRepository.Add(5);

            stringRepository.Add("apple");
            stringRepository.Add("banana");
            stringRepository.Add("cherry");
            stringRepository.Add("date");
            stringRepository.Add("fig");

            Criteria<int> intCriteria = item => item % 2 == 0;
            Criteria<string> stringCriteria = item => item.Length <= 5;

            List<int> evenNumbers = intRepository.Find(intCriteria);
            List<string> shortStrings = stringRepository.Find(stringCriteria);

            Console.WriteLine("Результати для різних типів даних:");
            Console.WriteLine("Парні числа:");
            foreach (int number in evenNumbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Рядки з довжиною менше або дорівнює 5:");
            foreach (string str in shortStrings)
            {
                Console.WriteLine(str);
            }
        }
    }

}
