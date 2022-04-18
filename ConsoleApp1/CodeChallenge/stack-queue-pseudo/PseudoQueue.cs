using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PseudoQueue
    {


        Stack stack1 = new Stack();
        Stack stackQueue = new Stack();


        public void enqueue(string val)
        {


            while (stackQueue.peek() != "Stack is empty !!")
            {
                stack1.push(stackQueue.pop());
         
            }

            stack1.push(val);

            while (stack1.peek() != "Stack is empty !!")
            {
                stackQueue.push(stack1.pop());
            }



        }
        public string dequeue()
        {
            
            string result = stackQueue.pop();
            return result;

        }

        // for testing if it work as Queue
        public string peek()
        {
            return stackQueue.peek();

        }
    }
}
