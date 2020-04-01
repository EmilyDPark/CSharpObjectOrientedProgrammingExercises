using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_DesignAStack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            stack.Clear();
            Console.WriteLine();

            int ini = 0;
            int max = 5;

            for (int i = ini; i <= max; i++)
                stack.Push(i);

            for (int i = ini; i <= max; i++)
                Console.WriteLine(stack.Pop());
        }
    }
}
