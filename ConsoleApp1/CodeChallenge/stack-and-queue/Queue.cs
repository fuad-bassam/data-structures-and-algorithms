using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class Queue
    {

        Node  front = new Node();

        Node rear;


        /// <summary>
        /// to add elemnt at the first of Queue
        /// </summary>
        /// <param name="value"></param>
        public void enqueue(String value)
     {
            Node node = new Node(value);
            if (front.Value == null)
            {
                front = node;
                rear = front;
            }
            else
            {
                rear.next = node;
                rear = rear.next;
            }
            Console.WriteLine($"Enqueue {value} done successfully");

        }

        /// <summary>
        /// to renove the last element in the Queue
        /// </summary>
        /// <returns></returns>
     public string dequeue()
     {
            Node node = front;
            if (front == null)
            {
                //  return null;
                return "Queue is empty !!";
            }
            front = front.next;
            if (isEmpty())
            {
                rear = null;
            }
            return node.Value;


      }
     public String peek()
     {
            if (isEmpty())
            {
                return "Queue is empty !!";
            }

            return rear.Value;


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
