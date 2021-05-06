using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();
            myStack.push("Allen");
            myStack.push("Bob");
            myStack.push("Chris");
            myStack.push("Dave");
           
            Console.WriteLine(myStack.pop().name);
            Console.WriteLine(myStack.pop().name);
            Console.WriteLine(myStack.pop().name);
            Console.WriteLine(myStack.pop().name);
            Console.WriteLine(myStack.pop().name);
            
        }
    }
}
