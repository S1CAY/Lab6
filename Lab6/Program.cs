using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator<int> intCalculator = new Calculator<int>();
            Calculator<double> doubleCalculator = new Calculator<double>();
            Calculator<float> floatCalculator = new Calculator<float>();

            int intResult = intCalculator.PerformOperation(5, 3, intCalculator.Add);
            double doubleResult = doubleCalculator.PerformOperation(5.5, 2.0, doubleCalculator.Divide);
            float floatResult = floatCalculator.PerformOperation(4.5f, 1.5f, floatCalculator.Multiply);

            Console.WriteLine("Результати для різних типів даних:");
            Console.WriteLine($"Додавання (int): {intResult}");
            Console.WriteLine($"Ділення (double): {doubleResult}");
            Console.WriteLine($"Множення (float): {floatResult}");
        }
    }

}
