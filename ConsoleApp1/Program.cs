using System;
using ConsoleApp1.codeCha;


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



        static void Main(string[] args)
        {


            ///////array-reverse challenge           
            String[] arrReverse = { "5", "6", "7" };
            //  Class1.showArray(Class1.reverseArray(arrReverse));
            Class1.ShowArray(Class1.ReversArray(arrReverse));

            //////////////


            ///////////// array-insert-shift challenge
            int[] arrInsertShift = { 1, 2, 3, 4 };

            Console.WriteLine("the array after that we want to change it");
            arrayIntElementToConsole(arrInsertShift);

            int numInMiddel = 0;

            do
            {

                Console.WriteLine("Enter number to insert it in the middle");

            } while (!int.TryParse(Console.ReadLine(), out numInMiddel));


            int[] arrInsertShift02 = Class02.insertShiftArray(arrInsertShift, numInMiddel);
            Console.WriteLine("the array after add number in the middle");
            arrayIntElementToConsole(arrInsertShift02);

            arrInsertShift02 = Class02.deleteShiftArray(arrInsertShift02);
            Console.WriteLine("the array after delete number in the middle");
            arrayIntElementToConsole(arrInsertShift02);

            ///////////////////////////////////////


            Console.ReadKey();


        }
    }
}
