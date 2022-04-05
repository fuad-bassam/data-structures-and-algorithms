using ConsoleApp1.codeCha;
using System;


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



        ////////// call-Challenge5-linked-list
        public static void Call_LinkedList() {
            try
            {
                LinkedList linkl = new LinkedList();
                linkl.insert("8");
                linkl.insert("6");
                linkl.insert("4");
                linkl.appendElement("12");
                linkl.insertAfter("13","6");
                linkl.insertBefore("15","4");
                Console.Write(linkl.toString());
                Console.WriteLine($"is there {4} " + linkl.indicates("4"));
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
          
        }

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
                Console.WriteLine("the value is "+ linkl.kthFromEnd(3));
                Console.WriteLine("the value is "+linkl.kthFromEnd(0));

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

        }



        //call-Challenge8-linked-list-zip

        public static LinkedList zipList(LinkedList list1, LinkedList list2)
        {
            Node pointer = list1.FirstNode;
            Node selectNode;

            if (pointer == null)
                return list2;




            while (pointer != null)
            {
                if (  list2.FirstNode != null)
                {
                    selectNode = list2.FirstNode;

               
                     list2.FirstNode = list2.FirstNode.next;


                    selectNode.next = pointer.next;
                    pointer.next = selectNode;

                    if ( pointer.next.next == null && list2.FirstNode != null)
                    {
                        pointer.next.next = list2.FirstNode;
                        return list1;
                    }



                    pointer = pointer.next.next;
                }
                else
                {
                    return list1;
                }

            }


            


            return list1;
        }
        static void Main(string[] args)
        {




            ///////////Class8 methods  linked-list-zip
            Console.WriteLine("List 1");

            LinkedList list1 = new LinkedList();
            list1.appendElement("a");
            list1.appendElement("b");
           // list1.appendElement("c");

            Console.WriteLine( "\n List 2");

            LinkedList list2 = new LinkedList();
            list2.appendElement("x");
            list2.appendElement("y");
            list2.appendElement("z");


            Console.WriteLine("\n Zip list1 and list2");
            list1 =  zipList(list1,list2);

            Console.WriteLine(list1.toString());


            /////////////////////////



            ////////Class7 methods kthFromEndList

            //  Call_LinkedList3();

            //////////////////////////


            ////////// linked-list-insertions



            // Call_LinkedList2();

            ////////////////////











            /////////linked-list Challenge

            // Call_LinkedList();

            //////////////

            /////////array-reverse challenge           
            //String[] arrReverse = { "5", "6", "7" };
            ////  Class1.showArray(Class1.reverseArray(arrReverse));
            //Class1.ShowArray(Class1.ReversArray(arrReverse));

            ////////////////


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


            ////////array-binary-search challenge

            //int[] binarySearch_arr = { 2, 3, 2, 7, 4, 6, 5 };


            //Console.WriteLine(Class3.BinarySearch(Class3.SortArray(binarySearch_arr), 9));
            //////////////////////////


            Console.ReadKey();


        }
    }
}
