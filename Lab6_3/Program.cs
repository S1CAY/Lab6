using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab6_3
{
 
    class Program
    {
        static void Main()
        {
            
            Func<string, int> customFunction = key =>
            {
                Console.WriteLine($"Виконання користувацької функції для клавіші: {key}");
                return key.Length;
            };

            
            var cache = new FunctionCache<string, int>(customFunction);

            string key1 = "Hello";
            string key2 = "World";

           
            int result1 = cache.GetResult(key1, TimeSpan.FromMinutes(1));
            Console.WriteLine($"Результат для key1: {result1}");

           
            int result2 = cache.GetResult(key1, TimeSpan.FromMinutes(1));
            Console.WriteLine($"Результат для key1 (кешований): {result2}");

            
            int result3 = cache.GetResult(key2, TimeSpan.FromMinutes(1));
            Console.WriteLine($"Результат для key2: {result3}");
        }
    }

}
