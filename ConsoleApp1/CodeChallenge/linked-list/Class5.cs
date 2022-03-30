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


      public Node head;


        //Node node = new Node();
       public LinkedList(int val) {

            head = new Node(val);
            

        }
        public LinkedList()
        {

            head = new Node();


        }



        /// <summary>
        //// Print linked-list
        /// </summary>
        public String Tostring() {

           // Console.Write("[" + head.Value + "] ->");
            //if (head.next != null)
            //{
            //    Tostring(head.next);
            //}
            Node Count = head;
            string word ="";
            while (Count != null )
            { word += "[" + Count.Value + "] ->";
                Count = Count.next;
                if (Count == null)
                {
                    word += "NULL";
                }

            }

            return word;
        }


        /// <summary>
        /// /serch for element in linked list
        /// </summary>
        /// <param name="val"> thee value for search element </param>
        /// <returns></returns>
        public bool Indicates(int val) {

           
            Node node = head;
            while (node != null)
            {

                if (node.Value==val)
                {
                    return true;
                }
                node = node.next;
            }



            return false;
        }

        /// <summary>
        /// add element in the first of linked list
        /// </summary>
        /// <param name="val"></param>
        public void Insert(int val) {
          
            Node addVal = new Node(val);
                addVal.next = head;
                head = addVal;
           Console.WriteLine("add " + head.Value);
        
           }


      


        /// <summary>
        /// add elemnt in the last of linked list
        /// </summary>
        /// <param name="val">the value of the new element</param>
        public void AppendElement(int val)
        {
            Node addVal = new Node(val);

            Node node = head;


            //if the list is empty
            if (node == null) {

                node = addVal;

            }

            while (node.next != null)
            {
                node = node.next;

            }
            node.next = addVal;

            Console.WriteLine("add " + addVal.Value+" in the end of list");
        }

        /// <summary>
        /// add node to the list before the palace that user want
        /// </summary>
        /// <param name="val">the value of the new element</param>
        /// <param name="place">where the place we want to insert before</param>
        public void InsertBefore(int val ,int place)
        {


            Node addVal = new Node(val);

            Node node = head;


            //if the list is empty
            if (node == null)
            {

                node = addVal;

            }
          



                while (node.next.Value != place)
                {

                    if (node == null)
                    {
                        break;
                    }

                    node = node.next;

                }


                if (node.next == null)
                {

                    Console.WriteLine("element is not you want to add before " + place);
                }
                else
                {

                    addVal.next = node.next;
                    node.next = addVal;


                    Console.WriteLine("add " + node.next.Value + " before " + place);
                }


            

        }
        /// <summary>
        /// add node to the list after the palace that user want
        /// </summary>
        /// <param name="val">the value of the new element</param>
        /// <param name="place">where the place we want to insert after/param>
        public void InsertAfter(int val, int place)
        {


            Node addVal = new Node(val);

            Node node = head;


            //if the list is empty
            if (node == null)
            {

                node = addVal;

            }

            while (node.Value != place)
            {

              

                node = node.next;
                if (node == null)
                {
                    break;
                }
            }

            if (node == null)
            {

                Console.WriteLine("element is not you want to add after "+place);
            }
            else
            {


                addVal.next = node.next;
                node.next = addVal;
                

                Console.WriteLine("add " + node.next.Value + " afrer "+place);
            }



        }






    }



   


}
