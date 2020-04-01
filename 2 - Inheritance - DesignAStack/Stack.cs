using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_DesignAStack
{
    class Stack
    {
        private readonly List<object> stack = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException();

            stack.Add(obj);
        }

        public object Pop()
        {
            if (stack.Count == 0)
                throw new InvalidOperationException();

            var pop = stack[stack.Count - 1];
            stack.RemoveAt(stack.Count - 1);
            return pop;
        }

        public void Clear()
        {
            stack.Clear();
        }
    }
}
