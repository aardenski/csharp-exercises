using System;
using System.Collections.Generic;

namespace Intermediete_Exercises
{
    //Design a class called Stack with three methods.
    //void Push(object obj) / object Pop() / void Clear()
    //The Push() method stores the given object on top of the stack. We use the “object” type here so
    //we can store any objects inside the stack. Remember the “object” class is the base of all classes
    //in the .NET Framework. So any types can be automatically upcast to the object. Make sure to
    //take into account the scenario that null is passed to this object. We should not store null
    //references in the stack. So if null is passed to this method, you should throw an
    //InvalidOperationException.
    //The Pop() method removes the object on top of the stack and returns it. Make sure to take into
    //account the scenario that we call the Pop() method on an empty stack. In this case, this method
    //should throw an InvalidOperationException.
    //The Clear() method removes all objects from the stack.
    //We should be able to use this stack class as follows:
    //var stack = new Stack();
    //stack.Push(1);
    //stack.Push(2);
    //stack.Push(3);
    //Console.WriteLine(stack.Pop());
    //Console.WriteLine(stack.Pop());
    //Console.WriteLine(stack.Pop());
    //The output of this program will be
    //3
    //2
    //1
    public class Stack
    {
        private List<object> stack = new List<object>();

        public Stack() { }

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("pushed null object");
            else
                stack.Add(obj);
        }

        public object Pop()
        {
            object last = new { };

            if (stack.Count > 0)
            {
                last = stack[stack.Count - 1];
                stack.Remove(stack[stack.Count - 1]);
                return last;
            }
            else
                throw new InvalidOperationException("Cant Pop from empty stack");
        }

        public void Clear()
        {
            stack.Clear();
        }
    }
}
