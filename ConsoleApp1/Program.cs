﻿using ConsoleApp1.codeCha;
using System;


namespace ConsoleApp1
{

    class Program
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
                LinkedList linkl = new LinkedList(5);
                linkl.Insert(8);
                linkl.Insert(6);
                linkl.Insert(4);
                linkl.AppendElement(12);
                linkl.InsertAfter(13,6);
                linkl.InsertBefore(15,4);
                Console.Write(linkl.Tostring());
                Console.WriteLine($"is there {4} " + linkl.Indicates(4));
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
                LinkedList linkl = new LinkedList(5);
                
                linkl.AppendElement(12);
                linkl.AppendElement(11);
                linkl.AppendElement(10);
                linkl.AppendElement(9);
                linkl.AppendElement(8);
                linkl.InsertAfter(13, 8);
              //  linkl.InsertBefore(15, 12);
                Console.Write(linkl.Tostring());
        
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

        }


        static void Main(string[] args)
        {





            ////////// linked-list-insertions



            Call_LinkedList2();



            //////////////////////////










            /////////linked-list Challenge

           // Call_LinkedList();

            //////////////

            /////////array-reverse challenge           
            //String[] arrReverse = { "5", "6", "7" };
            ////  Class1.showArray(Class1.reverseArray(arrReverse));
            //Class1.ShowArray(Class1.ReversArray(arrReverse));

            ////////////////


            /////////////// array-insert-shift challenge
            //int[] arrInsertShift = { 1, 2, 3, 4 };

            //Console.WriteLine("the array after that we want to change it");
            //arrayIntElementToConsole(arrInsertShift);

            //int numInMiddel = 0;

            //do
            //{

            //    Console.WriteLine("Enter number to insert it in the middle");

            //} while (!int.TryParse(Console.ReadLine(), out numInMiddel));


            //int[] arrInsertShift02 = Class02.insertShiftArray(arrInsertShift, numInMiddel);
            //Console.WriteLine("the array after add number in the middle");
            //arrayIntElementToConsole(arrInsertShift02);

            //arrInsertShift02 = Class02.deleteShiftArray(arrInsertShift02);
            //Console.WriteLine("the array after delete number in the middle");
            //arrayIntElementToConsole(arrInsertShift02);

            /////////////////////////////////////////


            ////////array-binary-search challenge

            //int[] binarySearch_arr = { 2, 3, 2, 7, 4, 6, 5 };


            //Console.WriteLine(Class3.BinarySearch(Class3.SortArray(binarySearch_arr), 9));
            //////////////////////////


            Console.ReadKey();


        }
    }
}
