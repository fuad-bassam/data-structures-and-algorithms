using System;

using Xunit;
using ConsoleApp1;
using CodeChallenge.CodeChallenge.Hash;
using System.Collections.Generic;

namespace TestProject1
{
    public class ProgramTest
    {

        /// class30: HashTable
        [Fact]
        /// test  Setting a key/value to your hashtable results in the value being in the data structure
        public void Class30_test1()
        {

            HashTable hashTable = new HashTable();

            hashTable.set("s", 15);
            hashTable.set("ss", 25);
            Assert.Equal(15,hashTable.arrayvalue[   hashTable.hash("s")  ]);
        }
        [Fact]
        /// test Retrieving based on a key returns the value stored
        public void Class30_test2()
        {

            HashTable hashTable = new HashTable();

            hashTable.set("s", 15);
            hashTable.set("ss", 25);
            Assert.Equal(15, hashTable.get("s"));
        }
        [Fact]
        /// test  Successfully returns null for a key that does not exist in the hashtable
         public void Class30_test3()
        {

            HashTable hashTable = new HashTable();

            hashTable.set("s", 15);
            hashTable.set("ss", 25);
            hashTable.set("as", 55);
            Assert.True(!hashTable.contains("fuad")); }
   
      
        [Fact]
        /// test  Successfully handle a collision within the hashtable
        public void Class30_test4()
        {

            HashTable hashTable = new HashTable();

            hashTable.set("var", 15);
            hashTable.set("var", 25);
            Assert.Equal(25, hashTable.get("var"));
        }
        [Fact]
        /// test  Successfully retrieve a value from a bucket within the hashtable that has a collision
        public void Class30_test5()
        {

            HashTable hashTable = new HashTable();

            hashTable.set("ss", 15);
            hashTable.set("ss", 25);
            hashTable.set("as", 55);
            hashTable.set("af", 35);
            hashTable.set("am", 53);
            hashTable.set("al", 62);

            Assert.Equal(25, hashTable.get("ss"));
        }
        [Fact]
        /// test  Successfully hash a key to an in-range value
        public void Class30_test6()
        {

            HashTable hashTable = new HashTable();

            Assert.True(hashTable.arrayvalue.Length > hashTable.hash("varadd" ));
        }

        [Fact]
        /// test  Successfully returns a list of all unique keys that exist in the hashtable

        public void Class30_test7()
        {

            HashTable hashTable = new HashTable();
            hashTable.set("vas", 25);
            hashTable.set("ome", 35);
            hashTable.set("kar", 45);
            List<string> list1 = new List<string>() { "kar", "ome", "vas"};
           //{ "vas","ome","kar" }
            Assert.Equal(list1, hashTable.keys());
        }
        /// class28: Quick Sort

        [Fact]
        /// test it in happy case 1
        public void Class28_test1()
        {

            int[] arr = { 2, 4, 3, 6, 1, 5 };

            Program.QuickSort(arr, 0, arr.Length - 1);
            int[] test = { 1, 2, 3, 4, 5, 6 };
            Assert.Equal(test, arr);
        }
        [Fact]
        /// test it in happy case 2
        public void Class28_test2()
        {

            int[] arr = { 2, 4, 3, -1, 6, 1, 3, 5 };

            Program.QuickSort(arr, 0, arr.Length - 1);
            int[] test = { -1, 1, 2, 3, 3, 4, 5, 6 };
            Assert.Equal(test, arr);
        }
        [Fact]
        /// test it in happy case 3
        public void Class28_test3()
        {

            int[] arr = { 2, 2, 2, 2, 2, 2, 2, 2 };

            Program.QuickSort(arr, 0, arr.Length - 1);
            int[] test = { 2, 2, 2, 2, 2, 2, 2, 2 };
            Assert.Equal(test, arr);
        }
        [Fact]
        /// test it in happy case 4
        public void Class28_test4()
        {

            int[] arr = { -2, 50, -30, 1, 14, 1, 35, -14 };

            Program.QuickSort(arr, 0, arr.Length - 1);
            int[] test = { -30, -14, -2, 1, 1, 14, 35, 50 };
            Assert.Equal(test, arr);
        }
        [Fact]
        /// test if the array is empty
        public void Class28_ifNullarr()
        {

            int[] arr = { };

            Program.QuickSort(arr, 0, arr.Length - 1);
            int[] test = { };
            Assert.Equal(test, arr);
        }
        [Fact]
        /// test have one value
        public void Class28_OneValue()
        {

            int[] arr = { 1 };

            Program.QuickSort(arr,0,arr.Length-1);
            int[] test = { 1 };
            Assert.Equal(test, arr);
        }





        /// class27: Merge Sort

        [Fact]
        /// test it in happy case 1
        public void Class27_test1()
        {

            int[] arr = { 2, 4, 3, 6, 1, 5 };

            int[] arr2 = Program.MergeSort(arr);
            int[] test = { 1, 2, 3, 4, 5, 6 };
            Assert.Equal(test, arr2);
        }
        [Fact]
        /// test it in happy case 2
        public void Class27_test2()
        {

            int[] arr = { 2, 4, 3, -1, 6, 1, 3, 5 };

            int[] arr2 = Program.MergeSort(arr);
            int[] test = { -1, 1, 2, 3, 3, 4, 5, 6 };
            Assert.Equal(test, arr2);
        }
        [Fact]
        /// test it in happy case 3
        public void Class27_test3()
        {

            int[] arr = { 2, 2, 2, 2, 2, 2, 2, 2 };

            int[] arr2 = Program.MergeSort(arr);
            int[] test = { 2, 2, 2, 2, 2, 2, 2, 2 };
            Assert.Equal(test, arr2);
        }
        [Fact]
        /// test it in happy case 4
        public void Class27_test4()
        {

            int[] arr = { -2, 50, -30, 1, 14, 1, 35, -14 };

            int[] arr2 = Program.MergeSort(arr);
            int[] test = { -30, -14, -2, 1, 1, 14, 35, 50 };
            Assert.Equal(test, arr2);
        }
        [Fact]
        /// test if the array is empty
        public void Class27_ifNullarr()
        {

            int[] arr = { };

            int[] arr2 = Program.MergeSort(arr);
            int[] test = { };
            Assert.Equal(test, arr2);
        }
        [Fact]
        /// test have one value
        public void Class27_OneValue()
        {

            int[] arr = { 1};

            int[] arr2 = Program.MergeSort(arr);
            int[] test = { 1 };
            Assert.Equal(test, arr2);
        }






        /// class26: InsertionSort

        [Fact]
        /// test it in happy case 1
        public void Class26_test1()
        {

            int[] arr = { 2, 4, 3, 6, 1, 5 };

            int[] arr2 = Program.InsertionSort(arr);
            int[] test = { 1, 2, 3, 4, 5, 6 };
            Assert.Equal(test,arr2);
        }
        [Fact]
        /// test it in happy case 2
        public void Class26_test2()
        {

            int[] arr = { 2, 4, 3,-1, 6, 1,3, 5 };

            int[] arr2 = Program.InsertionSort(arr);
            int[] test = {-1, 1, 2, 3,3, 4, 5, 6 };
            Assert.Equal(test, arr2);
        }
        [Fact]
        /// test it in happy case 3
        public void Class26_test3()
        {

            int[] arr = { 2, 2, 2, 2, 2, 2, 2, 2 };

            int[] arr2 = Program.InsertionSort(arr);
            int[] test = { 2, 2, 2, 2, 2, 2, 2, 2 };
            Assert.Equal(test, arr2);
        }
        [Fact]
        /// test it in happy case 4
        public void Class26_test4()
        {

            int[] arr = { -2, 50, -30, 1, 14, 1, 35, -14 };

            int[] arr2 = Program.InsertionSort(arr);
            int[] test = { -30, -14, -2, 1, 1, 14, 35, 50 };
            Assert.Equal(test, arr2);
        }
        [Fact]
        /// test it in happy case 1
        public void Class26_ifNullarr()
        {

            int[] arr = { };

            int[] arr2 = Program.InsertionSort(arr);
            int[] test = { };
            Assert.Equal(test, arr2);
        }


        ///Class 13: stack-queue-brackets
        [Fact]

        public void Class13_test1()
        {
            String x = "[x]";

            Assert.True(Program.validateBrackets(x));
        }
        [Fact]
     
        public void Class13_test2()
        {

            String x = "[][]{}";

            Assert.True(Program.validateBrackets(x));

        }

        [Fact]
        public void Class13_test3()
        {

            String x = "{s]";

            Assert.True(!Program.validateBrackets(x));

        }

        [Fact]
        public void Class13_test4()
        {


            String x = "{[(z)]}";

            Assert.True(Program.validateBrackets(x));

        }
        /////////

    }
}