using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    class Stack
    {
        Node top = null;
        public Stack()
        {

        }
        public void push(string name)
        {
                Node newNode = new Node(name, top);
                top = newNode;
        }
        public Node pop()
        {
            Node returnNode = top;
            if(top != null)
            {             
                top = top.next;
                return returnNode;
            }
            else
            {
                return new Node("Empty Stack", null);
            }
                       
        }
       
    }
}
