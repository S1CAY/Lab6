using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class Calculator<T>
    {
        public delegate T Operation(T a, T b);

        public Operation Add { get; }
        public Operation Subtract { get; }
        public Operation Multiply { get; }
        public Operation Divide { get; }

        public Calculator()
        {
            Add = (a, b) => (dynamic)a + (dynamic)b;
            Subtract = (a, b) => (dynamic)a - (dynamic)b;
            Multiply = (a, b) => (dynamic)a * (dynamic)b;
            Divide = (a, b) => (dynamic)a / (dynamic)b;
        }

        public T PerformOperation(T a, T b, Operation operation)
        {
            return operation(a, b);
        }
    }
}
