using System;

using Xunit;
using ConsoleApp1;
using CodeChallenge.CodeChallenge.Hash;
using System.Collections.Generic;
using static ConsoleApp1.Program;

namespace TestProject1
{
    public class ProgramTest
    {



        //class32 :tree_intersection

        [Fact]
        /// test  return all data 
        public void Class32_test1()
        {
            List<BinaryTree> TreeData = Program.demoTreeData();


            List<int> resultList = tree_intersection(TreeData[0], TreeData[1]);
            string stringAllData = null;

            foreach (int item in resultList)
            {
                stringAllData += $"{item}|";
            }
            Assert.Equal("50|115|5|", stringAllData);
        }

        [Fact]
        /// test  null data 
        public void Class32_test2()
        {
            List<BinaryTree> TreeData = Program.demoTreeData();


            List<int> resultList = tree_intersection(TreeData[0], null);
            
            Assert.Null(resultList);
        }

        [Fact]
        /// test  null data 
        public void Class32_test3()
        {
            List<BinaryTree> TreeData = Program.demoTreeData();

            BinaryTree emptyList = new BinaryTree();

            List<int> resultList = tree_intersection(TreeData[0], emptyList);

            
            Assert.Null(resultList);
        }

        [Fact]
        /// test  row data 
        public void Class32_test4()
        {
            List<BinaryTree> TreeData = Program.demoTreeData();


            List<int> resultList = tree_intersection(TreeData[0], TreeData[1]);
            string stringAllData = null;

            
            Assert.Contains(5, resultList);
        }



        ////class33 :hashmap leftJoin
        public List<HashTable> demoHashTableData() {


            HashTable hashTable1 = new HashTable();
            hashTable1.set("first", 1);
            hashTable1.set("second", 2);
            hashTable1.set("third", 3);
            hashTable1.set("the 6th", 6);
            HashTable hashTable2 = new HashTable();
            hashTable2.set("first", 1);
            hashTable2.set("second", 2);
            hashTable2.set("third", 3);
            hashTable2.set("the forth", 4);

            List<HashTable> hashTables = new List<HashTable>();

            hashTables.Add(hashTable1);
            hashTables.Add(hashTable2);

            return hashTables;
        }
        [Fact]
        /// test  return all data 
        public void Class33_test1()
        {
            List<HashTable> hashData = demoHashTableData();
            
            var listData =Program.hashmapLeftJoin(hashData[0], hashData[1]);
            string stringAllData = null;

            foreach (var item in listData)
            {
                stringAllData += $"{item.key}{item.table1Data}{item.table2Data}|";
            }
            Assert.Equal("the 6th6|second22|third33|first11|the forth4|", stringAllData);
        }
        [Fact]
        /// test  return row data 
        public void Class33_test2()
        {

            List<HashTable> hashData = demoHashTableData();
            var listData = Program.hashmapLeftJoin(hashData[0], hashData[1]);

            HashJoinTable rowDate = listData.Find(x => x.key == "third");
            Assert.Equal("third33", $"{rowDate.key }{rowDate.table1Data }{rowDate.table2Data}");

        }
        [Fact]
        /// test  return null data  
        public void Class33_test3()
        {

            List<HashTable> hashData = demoHashTableData();
            var listData = Program.hashmapLeftJoin(hashData[0], hashData[1]);

            HashJoinTable rowDate = listData.Find(x => x.key == "the forth");
            Assert.Null(rowDate.table2Data);
        }

        [Fact]
        /// test  return null data 
        public void Class33_test4()
        {

            List<HashTable> hashData = demoHashTableData();
            var listData = Program.hashmapLeftJoin(hashData[0], hashData[1]);

            HashJoinTable rowDate = listData.Find(x => x.key == "the 6th");
            Assert.Equal("the 6th6", $"{rowDate.key }{rowDate.table1Data }{rowDate.table2Data}");

        }


        ////class31 :hashmap-repeated-word
        [Fact]
        /// test  repeated word 1
        public void Class31_test1()
        {
             string paragraph = "Once upon a time, there was a brave princess who...";



            Assert.Equal("a",Program. repeatedWord(paragraph));
        }
        [Fact]
        /// test  repeated word 2
        public void Class31_test2()
        {
            string paragraph = "It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only...";



            Assert.Equal("it", Program.repeatedWord(paragraph));
        }
        [Fact]
        /// test  repeated word 3
        public void Class31_test3()
        {
            string paragraph = "It was a queer, sultry summer, the summer they electrocuted the Rosenbergs, and I didn’t know what I was doing in New York...";



            Assert.Equal("summer", Program.repeatedWord(paragraph));
        }
        [Fact]
        /// test  if paragraph is empty 
        public void Class31_test4()
        {
            string paragraph="";


            Assert.Null(Program.repeatedWord(paragraph));
        }
        [Fact]
        /// test  if paragraph have one word 
        public void Class31_test5()
        {
            string paragraph = "Hello";



            Assert.Null( Program.repeatedWord(paragraph));
        }

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