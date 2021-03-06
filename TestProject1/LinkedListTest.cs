using System;

using Xunit;
using ConsoleApp1;

namespace TestProject1
{
    public class LinkedListTest
    {
        
        
        ///Class 05: Linked List Implementation
        [Fact]
        // test  if Can successfully instantiate an empty linked list 
        public void Class05_test1_CreateEmpty()
        {
            LinkedList test = new LinkedList();
            Assert.Null(test.toString());

        }


       [Fact]
        // test if Can properly insert into the linked list
        public void Class05_Test_FirstNode()
        {
            LinkedList test2 = new LinkedList();
            test2.insert("3");

            Assert.Equal("[3] ->NULL", test2.toString());

        }

        [Fact]
        // test The head property will properly point to the first node in the linked list
        public void Class05_Test_Head()
        {
            LinkedList test2 = new LinkedList();
            test2.insert("8");
            test2.insert("4");
            test2.insert("5");
            test2.insert("6");

            

            Assert.Equal("6", test2.getHead());


        }



        [Fact]
        // test if Can properly insert multiple nodes into the linked list
        public void Class05_Test_Multipleinsert()
        {
            LinkedList test3 = new LinkedList();
            test3.insert("2");
            test3.insert("3");
            test3.insert("4");
            test3.insert("5");
            test3.insert("6");
            test3.insert("7");

            Assert.Equal("[7] ->[6] ->[5] ->[4] ->[3] ->[2] ->NULL", test3.toString());
        }




        [Fact]
        // if Will return true when finding a value within the linked list that exists
        public void Class05_Test_indicatesReturn()
        {
            LinkedList test3 = new LinkedList();
            test3.insert("2");
            test3.insert("3");
            test3.insert("4");
            test3.insert("5");
            test3.insert("6");
            test3.insert("7");

            Assert.True(test3.indicates("5"));

        }


        [Fact]
        // if Will return false when searching for a value in the linked list that does not exist
        public void Class05_Test_indicatesReturnFalse()
        {
            LinkedList test3 = new LinkedList();
            test3.insert("2");
            test3.insert("3");
            test3.insert("4");
            test3.insert("5");
            test3.insert("6");
            test3.insert("7");

            Assert.True(!test3.indicates("10"));

        }


        [Fact]
        // if Can properly return a collection of all the values that exist in the linked list
        public void Class05_Test_toString()
        {
            LinkedList test3 = new LinkedList();
            test3.insert("4");
            test3.insert("6");
            test3.insert("8");
            test3.insert("10");
            test3.insert("12");
            test3.insert("14");

            Assert.Equal("[14] ->[12] ->[10] ->[8] ->[6] ->[4] ->NULL", test3.toString());

        }





        [Fact]
        // if Can successfully add a node to the end of the linked list
        public void Class06_Test_AddToEnd()
        {
            LinkedList test3 = new LinkedList();
            test3.appendElement("3");
            test3.appendElement("2");



            Assert.Equal("[3] ->[2] ->NULL", test3.toString());

        }



        [Fact]
        // if Can successfully add multiple nodes to the end of a linked list
        public void Class06_Test_AddMultiple()
        {
            LinkedList test3 = new LinkedList();
            test3.appendElement("2");
            test3.appendElement("3");
            test3.appendElement("4");
            test3.appendElement("5");
            test3.appendElement("6");
            test3.appendElement("7");

            Assert.Equal("[2] ->[3] ->[4] ->[5] ->[6] ->[7] ->NULL", test3.toString());

        }




        [Fact]
        // if Can successfully insert a node before the first node of a linked list
        public void Class06_Test_AddAfter()
        {
            LinkedList test3 = new LinkedList();
            test3.appendElement("2");
            test3.appendElement("3");
            test3.appendElement("4");
            test3.appendElement("5");
            test3.appendElement("6");
            test3.appendElement("7");
            test3.insertAfter("9", "4");


            Assert.Equal("[2] ->[3] ->[4] ->[9] ->[5] ->[6] ->[7] ->NULL", test3.toString());

        }
        [Fact]
        // if Can successfully insert a node before a node located i the middle of a linked list
        public void Class06_Test_AddBefore()
        {
            LinkedList test3 = new LinkedList();
            test3.appendElement("1");
            test3.appendElement("2");
            test3.appendElement("3");
            test3.appendElement("4");
            test3.appendElement("5");
            test3.appendElement("6");
            test3.appendElement("7");
            test3.insertBefore("9", "4");


            Assert.Equal("[1] ->[2] ->[3] ->[9] ->[4] ->[5] ->[6] ->[7] ->NULL", test3.toString());

        }

        [Fact]
        // if Can successfully insert a node before a node located i the middle of a linked list
        public void Class06_Test_AddBeforeFirst()
        {
            LinkedList test3 = new LinkedList();
            test3.appendElement("1");
            test3.appendElement("2");
            test3.appendElement("3");
            test3.appendElement("4");
            test3.appendElement("5");
            test3.appendElement("6");
            test3.appendElement("7");
            test3.insertBefore("9","1");


            Assert.Equal("[9] ->[1] ->[2] ->[3] ->[4] ->[5] ->[6] ->[7] ->NULL", test3.toString());

        }
        [Fact]
        // if Can successfully insert after a node in the middle of the linked list
        public void Class06_Test_AddAfterMid()
        {

            LinkedList test3 = new LinkedList();
            test3.appendElement("1");
            test3.appendElement("2");
            test3.appendElement("3");
            test3.appendElement("4");
            test3.appendElement("5");
            test3.appendElement("6");
            test3.appendElement("7");
            test3.insertAfter("9", "4");


            Assert.Equal("[1] ->[2] ->[3] ->[4] ->[9] ->[5] ->[6] ->[7] ->NULL", test3.toString());

        }



        [Fact]
        // if Can successfully insert a node after the last node of the linked list
        public void Class06_Test_AfterTheLast()
        {
            LinkedList test3 = new LinkedList();
            test3.appendElement("1");
            test3.appendElement("2");
            test3.appendElement("3");
            test3.appendElement("4");
            test3.appendElement("5");
            test3.appendElement("6");
            test3.appendElement("7");
            test3.insertAfter("9", "7");


            Assert.Equal("[1] ->[2] ->[3] ->[4] ->[5] ->[6] ->[7] ->[9] ->NULL", test3.toString());

        }

        
        [Fact]
        // test Where k is greater than the length of the linked list
        public void Class07_Test_KIsGreater()
        {
            LinkedList test3 = new LinkedList();
            test3.insert("2");
            test3.insert("3");
            test3.insert("4");
            test3.insert("5");
            test3.insert("6");
            test3.insert("7");

             Assert.Equal("ERROR, the selected number is NOT ok", test3.kthFromEnd(12));

          
        }


        [Fact]
        // test Where k and the length of the list are the same
        public void Class07_Test_KEeualListLength()
        {
            LinkedList test3 = new LinkedList();
            test3.insert("2");
            test3.insert("3");
            test3.insert("4");
            test3.insert("5");
            test3.insert("6");
            test3.insert("7");

            Assert.Equal("7", test3.kthFromEnd(5));


        }


        [Fact]
        // test Where k is not a positive integer
        public void Class07_Test_KNotpos()
        {
            LinkedList test3 = new LinkedList();
            test3.insert("2");
            test3.insert("3");
            test3.insert("4");
            test3.insert("5");
            test3.insert("6");
            test3.insert("7");


            Assert.Equal("ERROR, the selected number is NOT ok", test3.kthFromEnd(-1));



        }

        [Fact]
        // test Where the linked list is of a size 1
        public void Class07_Test_listOf1node()
        {
            LinkedList test3 = new LinkedList();
            test3.insert("a");
           


            Assert.Equal("a", test3.kthFromEnd(0));



        }


        [Fact]
        // test Happy Path where k is not at the end, but somewhere in the middle of the linked list
        public void Class07_Test_HappyPath()
        {
            LinkedList test3 = new LinkedList();
            test3.insert("a");
            test3.insert("b");
            test3.insert("c");
            test3.insert("d");
            test3.insert("e");
            test3.insert("f");


            Assert.Equal("d", test3.kthFromEnd(3));



        }




        [Fact]
        // test  if Can successfully combine two list with the same length
        public void Class08_Test1_ZipList()
        {
            LinkedList list1 = new LinkedList();
            list1.appendElement("a");
            list1.appendElement("b");
            list1.appendElement("c");



            LinkedList list2 = new LinkedList();
            list2.appendElement("x");
            list2.appendElement("y");
            list2.appendElement("z");


            list1 = Program.zipList(list1, list2);

            Assert.Equal("[a] ->[x] ->[b] ->[y] ->[c] ->[z] ->NULL", list1.toString());

        }

        [Fact]
        // test  if Can successfully combine two list with first list is greater than the second list
        public void Class08_Test2_ZipList2()
        {
            LinkedList list1 = new LinkedList();
            list1.appendElement("a");
            list1.appendElement("b");
            list1.appendElement("c");



            LinkedList list2 = new LinkedList();
            list2.appendElement("x");
            list2.appendElement("y");


            list1 = Program.zipList(list1, list2);

            Assert.Equal("[a] ->[x] ->[b] ->[y] ->[c] ->NULL", list1.toString());

        }

        [Fact]
        // test  if Can successfully combine two list with second list is greater than the first list
        public void Class08_Test3_ZipList3()
        {
            LinkedList list1 = new LinkedList();
            list1.appendElement("a");
            list1.appendElement("b");



            LinkedList list2 = new LinkedList();
            list2.appendElement("x");
            list2.appendElement("y");
            list2.appendElement("z");


            list1 = Program.zipList(list1, list2);

            Assert.Equal("[a] ->[x] ->[b] ->[y] ->[z] ->NULL", list1.toString());

        }

        [Fact]
        // test  if Can successfully combine two empty lists 
        public void Class08_Test4_ZipList_BothEmpty()
        {
            LinkedList list1 = new LinkedList();



            LinkedList list2 = new LinkedList();



            list1 = Program.zipList(list1, list2);

            Assert.Null(list1.toString());

        }

        [Fact]
        // test  if Can successfully combine two list with first list is empty
        public void Class08_Test5_ZipList_FirstEmpty()
        {
            LinkedList list1 = new LinkedList();




            LinkedList list2 = new LinkedList();
            list2.appendElement("x");
            list2.appendElement("y");
            list2.appendElement("z");


            list1 = Program.zipList(list1, list2);

            Assert.Equal("[x] ->[y] ->[z] ->NULL", list1.toString());

        }


        [Fact]
        // test  if Can successfully combine two list with second list is empty
        public void Class08_Test6_ZipList_SecondEmpty()
        {
            LinkedList list1 = new LinkedList();
            list1.appendElement("a");
            list1.appendElement("b");
            list1.appendElement("c");


            LinkedList list2 = new LinkedList();



            list1 = Program.zipList(list1, list2);

            Assert.Equal("[a] ->[b] ->[c] ->NULL", list1.toString());

        }




    }
}
