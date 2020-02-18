using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack2
{
    public class MyStack<T>
    {
        private T[] stack;
        public int Size { get; }
        private int top = 0;

        public MyStack(int size)
        {
            stack = new T[size];
            this.Size = size;
        }
        public void Push(T element)
        {
            if (top == Size) throw new MyStackIsFullException("The stack is full!");
            stack[top] = element;
            top++;
        }

        public T Pop()
        {
            if (top == 0) throw new MyStackIsEmptyException("The stack is empty!");
            return stack[--top];
        }

        public T Peek()
        {
            if (top == 0) throw new MyStackIsEmptyException("The stack is empty!");
            return stack[top];
        }
    }
}
