using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Queue
    {

        Node front = null;

        Node rear = null;


        /// <summary>
        /// to add elemnt at the first of Queue
        /// </summary>
        /// <param name="value"></param>
        public void enqueue(String value)
        {
            Node node = new Node(value);
            if (rear == null)
            {
                front = node;
                rear = front;
            }
            else
            {
                rear.next = node;
                rear = node;
            }
            Console.WriteLine($"Enqueue {value} done successfully");

        }

        /// <summary>
        /// to renove the last element in the Queue
        /// </summary>
        /// <returns></returns>
        public string dequeue()
        {

            if (isEmpty())
            {
                front = null;
                return null;
            }

            Node node = front;
            string node2 = front.Value;
           
            if (node.next == null)
            {
                string val = node.Value;
                rear = null;
                front = null;

                return val;

            }

            
                front = node.next;

            
            return node2;


        }
        public String peek()
        {
            if (isEmpty())
            {
            
                return "Queue is empty !!";
            }

            return front.Value;


        }
        /// <summary>
        ///  to check if the Queue is null or not
        /// </summary>
        /// <returns></returns>
        public bool isEmpty()
        {
            if (front == null)
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