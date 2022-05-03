using ConsoleApp1.codeCha;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{

    public class Program
    {


        public static void arrayIntElementToConsole(int[] arr)
        {

            Console.Write("The Result :- { ");

            foreach (int i in arr)
            {

                Console.Write(i + " ");
            }

            Console.WriteLine("} \n");


        }



        #region Lab 14: stack-queue-brackets
        public static string DDGgame(Queue<String> queue1, int key)
        {
            Queue<String> queue2 = new Queue<string>();
            int count = 0; bool turn = true;


            while (queue1.Count + queue2.Count != 1)
            {
                count = key;
                while (count != 0)
                {
                    if (turn)
                    {

                        queue2.Enqueue(queue1.Dequeue());
                        count--;
                    }
                    else
                    {
                        queue1.Enqueue(queue2.Dequeue());
                        count--;
                    }
                    if (queue1.Count == 0 || queue2.Count == 0)
                    { turn = !turn; }
                }
                if (turn)
                { Console.WriteLine(queue2.Dequeue()); }
                else
                { Console.WriteLine(queue1.Dequeue()); }
            }
            if (queue1.Peek() == null)
            { return queue2.Peek(); }
            else
            { return queue1.Peek(); }


        }

        #endregion


        #region Class 13: stack-queue-brackets

        public static bool validateBrackets(string str)
        {
            Stack stack = new Stack();
            foreach (char item in str)
            {
                if (item == '[' || item == '(' || item == '{')
                {
                    stack.push(item.ToString());
                }
                if (item == ']' || item == ')' || item == '}')
                {
                    string x;
                    if (item == ']')
                    {
                        x = "[";
                    } else if (item == ')')
                    {
                        x = "(";
                    } else
                    {
                        x = "{";
                    }

                    if (stack.peek() == x)
                    {
                        stack.pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            if (stack.peek() == "Stack is empty !!")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region call-linked-list
        ////////// call-Challenge5-linked-list
        public static void Call_LinkedList() {
            try
            {
                LinkedList linkl = new LinkedList();
                linkl.insert("8");
                linkl.insert("6");
                linkl.insert("4");
                linkl.appendElement("12");
                linkl.insertAfter("13", "6");
                linkl.insertBefore("15", "4");
                Console.Write(linkl.toString());
                Console.WriteLine($"is there {4} " + linkl.indicates("4"));
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

        }
        #endregion

        #region call-linked-list
        ////////// call-Challenge6-linked-list
        public static void Call_LinkedList2()
        {
            try
            {
                LinkedList linkl = new LinkedList();

                linkl.appendElement("12");
                linkl.appendElement("11");
                linkl.appendElement("10");
                linkl.appendElement("9");
                linkl.appendElement("8");
                linkl.insertAfter("13", "16");
                //  linkl.insertBefore(15, 12);
                Console.Write(linkl.toString());

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

        }
        #endregion

        #region call-linked-list-kth
        //call-Challenge7-linked-list-kth

        public static void Call_LinkedList3()
        {
            try
            {
                LinkedList linkl = new LinkedList();

                linkl.appendElement("12");
                linkl.appendElement("11");
                linkl.appendElement("10");
                linkl.appendElement("9");
                linkl.appendElement("8");


                //  Console.Write(linkl.toString());
                Console.WriteLine("the value is " + linkl.kthFromEnd(3));
                Console.WriteLine("the value is " + linkl.kthFromEnd(0));

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

        }
        #endregion

        #region call-linked-list-zip

        //call-Challenge8-linked-list-zip

        public static LinkedList zipList(LinkedList list1, LinkedList list2)
        {
            LinkedList list3 = list1.deepcopy();
            LinkedList list4 = (LinkedList)list2.deepcopy();
            Node pointer = list3.FirstNode;
            Node selectNode;

            if (pointer == null)
                return list4;




            while (pointer != null)
            {
                if (list4.FirstNode != null)
                {
                    selectNode = list4.FirstNode;


                    list4.FirstNode = list4.FirstNode.next;


                    selectNode.next = pointer.next;
                    pointer.next = selectNode;

                    if (pointer.next.next == null && list4.FirstNode != null)
                    {
                        pointer.next.next = list4.FirstNode;
                        return list3;
                    }



                    pointer = pointer.next.next;
                }
                else
                {
                    return list3;
                }

            }





            return list3;
        }
        #endregion

        #region Class 17: tree-breadth-first
        public static List<int> breadthFirst(TreeNode root)
        {
            Queue<TreeNode> brethQueue = new
            Queue<TreeNode>();
            List<int> brethList = new List<int>();

            brethQueue.Enqueue(root);
            while (brethQueue.Count() != 0)
            {
                TreeNode front = brethQueue.Dequeue();

                brethList.Add(front.Value);

                foreach (TreeNode node in front.children)
                {
                    brethQueue.Enqueue(node);
                }


                // in Binary tree

                //if (front.Left != null)
                //{ brethQueue.Enqueue(front.Left); }
                //if (front.Right != null)
                //{ brethQueue.Enqueue(front.Right); }
            }
            return brethList;
        }


        #endregion

        #region class 18: tree-fizz-buzz


        public static void fizzBuzzTree(BinaryTNode root, string testNode, K_aryTNode x)
        {
            string val;
            if (root.Value % 5 == 0 && root.Value % 3 == 0)
                val = "fizzBuzz";
            else if (root.Value % 5 == 0)
                val = "Buzz";
            else if (root.Value % 3 == 0)
                val = "fizz";
            else
                val = root.Value.ToString();
            K_aryTNode newTNode = new K_aryTNode(val);

            if (testNode == "null")
            {

                x = newTNode;
            }
            else if (testNode == "Left") {
            x = newTNode;
               }
            else if (testNode == "Right")
            { 
            x = newTNode;
            }
                x = newTNode;


            if (root.Left != null)
            {
                fizzBuzzTree(root.Left, "Left", x.Left); }
            if (root.Right != null)
            {
                fizzBuzzTree(root.Right, "Right", x.Right); }
        }
        public static K_aryTree callFizzBuzzTree(BinaryTree k_aryTree)
        {
          K_aryTree newK_aryTree = new K_aryTree();

           // K_aryTNode xs = newK_aryTree.root;
             fizzBuzzTree(k_aryTree.root, "null", newK_aryTree.root);
           // newK_aryTree.root = xs;
            return newK_aryTree;
        }

         
         #endregion
    static void Main(string[] args)
        {



            #region class 18: tree-fizz-buzz

            Console.WriteLine("Depth First as preOrder");
            BinaryTree binaryTree = new BinaryTree();


            BinaryTNode node21 = new BinaryTNode(15, null, null);
            BinaryTNode node12 = new BinaryTNode(5, null, null);
            BinaryTNode node11 = new BinaryTNode(115, null, null);
            BinaryTNode node2 = new BinaryTNode(10, node21, null);
            BinaryTNode node1 = new BinaryTNode(30, node11, node12);
            BinaryTNode rootNode = new BinaryTNode(50, node1, node2);

            binaryTree.root = rootNode;
            


           K_aryTree k_ary = callFizzBuzzTree(binaryTree);

            Console.Write(k_ary.root.Left.Value + " ");
            

            //foreach (var item in K_ary)
            //{
            //    Console.Write(item + " ");
            //}



            #endregion


            #region class 15 :trees
            // Console.WriteLine("Depth First as preOrder");
            // BinaryTree binaryTree = new BinaryTree();

            // ///// add element to tree like image in README file (Tree DATA)

            // BinaryTNode node21 = new BinaryTNode(15, null, null);
            // BinaryTNode node12 = new BinaryTNode(5, null, null);
            // BinaryTNode node11 = new BinaryTNode(115, null, null);
            // BinaryTNode node2 = new BinaryTNode(10, node21, null);
            // BinaryTNode node1 = new BinaryTNode(30, node11, node12);
            // BinaryTNode rootNode = new BinaryTNode(50, node1, node2);

            // binaryTree.root = rootNode;


            // foreach (var item in binaryTree.preOrder())
            // {
            //     Console.Write(item + " ");
            // }

            // ///// BST
            // Console.WriteLine("\n\nBST CLASS test code");

            // BSTree bsTree = new BSTree();

            // BinaryTNode rootNode2 = new BinaryTNode(50, null, null);

            //// bsTree.addRoot(rootNode2);

            // bsTree.add(50);
            // bsTree.add(52);
            // bsTree.add(55);

            // bsTree.add(15);
            // bsTree.add(20);
            // bsTree.add(23);

            // bsTree.add(51);
            // bsTree.add(30);
            // bsTree.add(53);
            // Console.WriteLine("is there 30 in the BSTree = "+bsTree.contains(30));
            // Console.WriteLine("is there 59 in the BSTree = " + bsTree.contains(59));
            #endregion

            #region call Class 17: tree-breadth-first
            //// add element to tree like image in README file(Tree DATA)

            //TreeNode node21 = new TreeNode(15);
            //TreeNode node12 = new TreeNode(5);
            //TreeNode node11 = new TreeNode(115);
            //TreeNode node2 = new TreeNode(10);
            //TreeNode node1 = new TreeNode(30);
            //TreeNode rootNode = new TreeNode(50);

            //rootNode.children.Add(node1);
            //rootNode.children.Add(node2);
            //node1.children.Add(node11);
            //node1.children.Add(node12);
            //node2.children.Add(node21);

            //List<int> listData = breadthFirst(rootNode);


            // Console.Write("[ ");

            //foreach (int item in listData)
            //{
            //    Console.Write(item + " ");
            //}

            //Console.WriteLine("]");


            #endregion


            #region Class 16: tree-max

            //BinaryTree binaryTree = new BinaryTree();

            /////// add element to tree like image in README file (Tree DATA)

            //BinaryTNode node21 = new BinaryTNode(15, null, null);
            //BinaryTNode node12 = new BinaryTNode(5, null, null);
            //BinaryTNode node11 = new BinaryTNode(115, null, null);
            //BinaryTNode node2 = new BinaryTNode(10, node21, null);
            //BinaryTNode node1 = new BinaryTNode(30, node11, node12);
            //BinaryTNode rootNode = new BinaryTNode(50, node1, node2);

            //binaryTree.root = rootNode;

            //Console.WriteLine("the max is " + binaryTree.findMaximum());


            #endregion


            #region Class 13: stack-queue-brackets

            //Console.WriteLine(validateBrackets("sds[]"));
            //Console.WriteLine(validateBrackets("{}(){}"));
            //Console.WriteLine(validateBrackets("()[[Extra Characters]]"));
            //Console.WriteLine(validateBrackets("{(})"));

            #endregion

            #region Class 12: stack-queue-animal-shelter

            // AnimalShelter animalShelter = new AnimalShelter();
            // Console.WriteLine(animalShelter.dequeue("cat"));
            // Cat cat = new Cat("cat1");
            // Cat cat2 = new Cat("cat2");
            // Dog dog = new Dog("dog1");
            // Cat cat5 = new Cat("cat5");





            // animalShelter.enqueue(cat);


            // animalShelter.enqueue(cat2);
            // animalShelter.enqueue(dog);
            // Console.WriteLine(animalShelter.dequeue("Lion"));
            //animalShelter.enqueue(cat5);



            // Console.WriteLine(animalShelter.dequeue("cat"));
            // Console.WriteLine(animalShelter.dequeue("cat"));

            #endregion

            #region Class 11: stack-queue-pseudo
            /////////////Class 11: stack-queue-pseudo



            //PseudoQueue pseudoqueue = new PseudoQueue();

            //pseudoqueue.enqueue("a");
            //Console.WriteLine("enqueue " + pseudoqueue.peek());

            //pseudoqueue.enqueue("b");
            //Console.WriteLine("enqueue b ");

            //pseudoqueue.enqueue("c");
            //Console.WriteLine("enqueue c \n");


            //Console.WriteLine("dequeue " + pseudoqueue.dequeue());

            //Console.WriteLine("dequeue " + pseudoqueue.dequeue());

            //Console.WriteLine("dequeue " + pseudoqueue.dequeue());

            //Console.WriteLine(pseudoqueue.peek());
            //pseudoqueue.enqueue("f");
            //Console.WriteLine(pseudoqueue.peek());
            //pseudoqueue.enqueue("b");
            //pseudoqueue.enqueue("c");
            //Console.WriteLine(pseudoqueue.peek());
            //Console.WriteLine(pseudoqueue.dequeue());
            //pseudoqueue.enqueue("d");
            //pseudoqueue.enqueue("e");
            //Console.WriteLine(pseudoqueue.dequeue());

            //Console.WriteLine(pseudoqueue.dequeue());

            //Console.WriteLine(pseudoqueue.dequeue());
            //Console.WriteLine("aaa "+pseudoqueue.peek());
            /////////////////////////////////////
            #endregion

            #region Class 10: Stack And Queue
            /////////////Class 10: Stack And Queue

            //Stack stack = new Stack();

            //Console.WriteLine(stack.peek());
            //Console.WriteLine(stack.pop());

            //stack.push("s");
            //Console.WriteLine(stack.peek());
            //Console.WriteLine(stack.pop());

            //if (stack.isEmpty())
            //{
            //    Console.WriteLine("stack is empty");
            //}


            //Queue queue = new Queue();

            //if (queue.isEmpty())
            //{
            //    Console.WriteLine("queue is empty");
            //}
            //queue.enqueue("a");
            //queue.enqueue("b");
            //queue.enqueue("c");
            //Console.WriteLine(queue.peek());
            //Console.WriteLine(queue.dequeue());

            //Console.WriteLine(queue.peek());
            //Console.WriteLine(queue.dequeue());
            //Console.WriteLine(queue.dequeue());
            //Console.WriteLine(queue.dequeue());
            /////////////////////////////////////
            #endregion

            #region Class8 methods  linked-list-zip
            ///////////Class8 methods  linked-list-zip
            //Console.WriteLine("List 1");

            //LinkedList list1 = new LinkedList();
            //list1.appendElement("a");
            //list1.appendElement("b");
            //list1.appendElement("c");

            //Console.WriteLine("\n List 2");

            //LinkedList list2 = new LinkedList();
            //list2.appendElement("x");
            //list2.appendElement("y");
            //list2.appendElement("z");


            //Console.WriteLine("\n Zip list1 and list2");
            //LinkedList list5 = zipList(list1, list2);

            //Console.WriteLine(list1.toString());
            //Console.WriteLine(list5.toString());
            //Console.WriteLine(list2.toString());

            /////////////////////////
            #endregion

            #region Class7 methods kthFromEndList

            ////////Class7 methods kthFromEndList

            //  Call_LinkedList3();

            //////////////////////////
            #endregion

            #region linked-list-insertions
            ////////// linked-list-insertions



            // Call_LinkedList2();

            ////////////////////

            #endregion

            #region linked-list Challenge

            /////////linked-list Challenge

            // Call_LinkedList();

            //////////////
            #region
            #endregion

            /////////array-reverse challenge           
            //String[] arrReverse = { "5", "6", "7" };
            ////  Class1.showArray(Class1.reverseArray(arrReverse));
            //Class1.ShowArray(Class1.ReversArray(arrReverse));

            ////////////////
            #endregion

            #region array-insert-shift challenge
            /////////////// array-insert-shift challenge
            //int[] arrinsertShift = { 1, 2, 3, 4 };

            //Console.WriteLine("the array after that we want to change it");
            //arrayIntElementToConsole(arrinsertShift);

            //int numInMiddel = 0;

            //do
            //{

            //    Console.WriteLine("Enter number to insert it in the middle");

            //} while (!int.TryParse(Console.ReadLine(), out numInMiddel));


            //int[] arrinsertShift02 = Class02.insertShiftArray(arrinsertShift, numInMiddel);
            //Console.WriteLine("the array after add number in the middle");
            //arrayIntElementToConsole(arrinsertShift02);

            //arrinsertShift02 = Class02.deleteShiftArray(arrinsertShift02);
            //Console.WriteLine("the array after delete number in the middle");
            //arrayIntElementToConsole(arrinsertShift02);

            /////////////////////////////////////////
            #endregion

            #region array-binary-search challenge
            ////////array-binary-search challenge

            //int[] binarySearch_arr = { 2, 3, 2, 7, 4, 6, 5 };


            //Console.WriteLine(Class3.BinarySearch(Class3.SortArray(binarySearch_arr), 9));
            //////////////////////////
            #endregion







            Console.ReadKey();


        }
    }
}
