using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Node {

        //int value;
       public Node next;

        public int Value { get; set; }

       // public Node Next { get; set; }

        public Node(int val) {
           this.Value = val;

            this.next = null; 
        }
     public  Node() {
            this.Value = 0;

            this.next = null;
        }
    }


   public class LinkedList{


        Node head;


        //Node node = new Node();
       public LinkedList(int val) {

            head = new Node(val);
            

        }
        public LinkedList()
        {

            head = new Node();


        }

        public void Tostring() {

           // Console.Write("[" + head.Value + "] ->");
            //if (head.next != null)
            //{
            //    Tostring(head.next);
            //}
            Node Count = head;
            while (Count != null)
            { Console.Write("[" + Count.Value + "] ->");
                Count = Count.next;
                if (Count == null)
                {
                    Console.WriteLine("NULL");
                }

            }


        }



        public bool Indicates(int val) {

            Node node = head;
            while (node != null)
            {

                if (node.Value==val)
                {
                    return true;
                }
            }



            return false;
        }

        public void Insert(int val) {
          
            Node addVal = new Node(val);
                addVal.next = head;
                head = addVal;
           Console.WriteLine("add " + head.Value);
           }

       }
    
}
