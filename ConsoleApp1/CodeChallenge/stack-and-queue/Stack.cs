using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{


    //public class Node2<T>
    //{

    //    //int value;
    //    public Node2<T> next;

    //    public T Value { get; set; }

    //    // public Node Next { get; set; }

    //    public Node2(T val)
    //    {
    //        this.Value = val;

    //        this.next = null;
    //    }
    //    public Node2()
    //    {

    //        this.Value = null;

    //        this.next = null;
    //    }
    //}

    public class Stack
    {

        //FILO
        Node top = new Node();

        /// <summary>
        /// method push to add elemnt in the stack 
        /// </summary>
        /// <param name="value">value to add it in the Stack</param>
        public void push(String value)
        {
            Node node = new Node(value);

             node.next= top;
            top = node;
            Console.WriteLine($"Push {value} done successfully");
        }

        /// <summary>
        /// pop to return and remove from the stack
        /// </summary>
        /// <returns></returns>
        public string pop()
        {
            if (top.Value == null)
            {
                // return null;
                return "Stack is empty !!";
            }

            String x = top.Value;
            top = top.next;
            return x;

        }


        /// <summary>
        /// to return the value of the top of the stack (first elemnet)
        /// </summary>
        /// <returns></returns>
        public string peek()
        {

            if (top.Value == null)
            {
                return "Stack is empty !!";
            }


            return top.Value;


        }

        /// <summary>
        /// to check if the Stack is null or not
        /// </summary>
        /// <returns></returns>
        public bool isEmpty()
        {
            if (top.Value == null )
            {
                return true;
            }
            else
            {
                return false;
            }


        }

    }
}
