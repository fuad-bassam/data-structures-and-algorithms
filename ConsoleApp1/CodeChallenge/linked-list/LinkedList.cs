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

        public String Value { get; set; }

       // public Node Next { get; set; }

        public Node(String val) {
           this.Value = val;
            
            this.next = null; 
        }
     public  Node() {

            this.Value = null;
         
            this.next = null;
        }
    }
    

    public class LinkedList
    {


        Node head;


        /// <summary>
        /// getter and aetter for the first node in list (the head)
        /// </summary>
        /// <returns></returns>
        ///////////Class8 methods  linked-list-zip
        ///
        public Node FirstNode
        {
            get { return head; }


            set{ head = value; }
        }
       



        //Class7 methods kthFromEndList

        /// <summary>
        /// get the length for the list
        /// </summary>
        /// <returns></returns>
        public int listLength()
        {

            Node node1 = head;
            int count = 1;

            if (node1 ==null)
            {
                return 0;
            }
           
          while (node1.next != null)
           {
                count++;
                node1 = node1.next;
           }
            return count;



        }


        /// <summary>
        /// get the value for the element that user select the node number from the last
        /// </summary>
        /// <param name="kth">the node number</param>
        /// <returns></returns>
        public String kthFromEnd(int kth)
        {

            Node node1 = head;
            int num;
           
            
          
                num = listLength() - kth;
           



            if (num <= 0 || kth<0)
            {
                return "ERROR, the selected number is NOT ok";
            }
            for (int i =1; i < num; i++)
            {
                node1 = node1.next;


            }
            return node1.Value;


}


        //Class5 methods

        /// <summary>
        /// add element in the first of linked list
        /// </summary>
        /// <param name="val"></param>
        public void insert(String val)
        {

            Node addVal = new Node(val);
            addVal.next = head;
            head = addVal;
            Console.WriteLine("add " + head.Value);

        }


        /// <summary>
        /// /search for element in linked list
        /// </summary>
        /// <param name="val"> thee value for search element </param>
        /// <returns></returns>
        public bool indicates(String val)
        {


            Node node = head;
            while (node != null)
            {

                if (node.Value == val)
                {
                    return true;
                }
                node = node.next;
            }



            return false;
        }

        /// <summary>
        //// Print linked-list
        /// </summary>
        public String toString()
        {

            Node Count = head;
            string word = null;
            while (Count != null)
            {
                word += "[" + Count.Value + "] ->";
                Count = Count.next;
                if (Count == null)
                {
                    word += "NULL";
                }

            }

            return word;
        }

        /// <summary>
        /// Check and get the place of head
        /// </summary>
        /// <returns></returns>
        public String getHead()
        {
            return head.Value;
        }





        //Class6 methods

        /// <summary>
        /// add element in the last of linked list
        /// </summary>
        /// <param name="val">the value of the new element</param>
        public void appendElement(String val)
        {
            Node addVal = new Node(val);

            Node node = head;


            //if the list is empty
            if (node == null)
            {

                head = addVal;
                Console.WriteLine("Add " + addVal.Value + " To The HEAD");
                return;
            }

            while (node.next != null)
            {
                node = node.next;

            }


            node.next = addVal;

            Console.WriteLine("add " + addVal.Value + " in the end of list");
        }

        /// <summary>
        /// add node to the list before the palace that user want
        /// </summary>
        /// <param name="val">the value of the new element</param>
        /// <param name="place">where the place we want to insert before</param>
        public void insertBefore(String val, String place)
        {


            Node addVal = new Node(val);

            Node node = head;


            //if the list is empty
            if (node == null)
            {

                node = addVal;

            }

            // if add to first
            if (node.Value == place)
            {

                addVal.next = head;
                head = addVal;
                return;
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

                Console.WriteLine("element " + place+" it NOT exist cant add before");
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
        public void insertAfter(String val, String place)
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

                Console.WriteLine("element " + place + " it NOT exist cant add after");
            }
            else
            {


                addVal.next = node.next;
                node.next = addVal;


                Console.WriteLine("add " + node.next.Value + " afrer " + place);
            }



        }




    }


}
