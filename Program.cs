using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> myStack = new MyStack<int>(6);


            try
            {
                MyStack<int> aStack = new MyStack<int>(4);

                int n = aStack.Pop();
                //myStack.Push(0);
                //myStack.Pop();
                ////Console.WriteLine(myStack.Pop());
                //myStack.Push(1);
                //myStack.Push(2);
                //myStack.Push(3);
                //myStack.Push(4);
                //myStack.Push(5);
                //myStack.Push(6);
            }
            catch (MyStackIsEmptyException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (MyStackIsFullException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();

        }
    }
}
