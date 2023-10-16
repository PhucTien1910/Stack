using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntStack
{
    internal class Program
    {
        static void Input(ArrayStack arrStack)
        {
            throw new NotImplementedException();
        }
        static void Output(ArrayStack arrStack)
        {
            throw new NotImplementedException();
        }
        static void TestArrayStack()
        {
            ArrayStack arrStack = new ArrayStack(1000);
            Input(arrStack);
            Console.Write("Cac gia tri trong Stack la: ");
            Output(arrStack);
        }
        static void Main(string[] args)
        {
            TestArrayStack();
            Console.ReadKey();
        }
    }
}
