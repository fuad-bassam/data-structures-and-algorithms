using System;

using Xunit;
using ConsoleApp1;

namespace TestProject1
{
    public class UnitTest1
    {
        
        
        ///Class 05: Linked List Implementation
        [Fact]
        // test  if Can successfully instantiate an empty linked list 
        public void Class05_test1_CreateEmpty()
        {
            LinkedList test = new LinkedList();
            Assert.Equal("[0] ->NULL", test.Tostring());

        }


       [Fact]
        // test if Can properly insert into the linked list
        public void Class05_Test_FirstNode()
        {
            LinkedList test2 = new LinkedList(3);

            Assert.Equal("[3] ->NULL", test2.Tostring());

        }

        [Fact]
        // test The head property will properly point to the first node in the linked list
        public void Class05_Test_Head()
        {
            LinkedList test2 = new LinkedList(3);
            test2.AppendElement(8);
            test2.AppendElement(4);
            test2.AppendElement(5);
            test2.AppendElement(6);

            Node head = test2.head;

            Assert.Equal("3", head.Value.ToString());


        }



        [Fact]
        // test if Can properly insert multiple nodes into the linked list
        public void Class05_Test_MultipleInsert()
        {
            LinkedList test3 = new LinkedList(3);
            test3.Insert(2);
            test3.Insert(3);
            test3.Insert(4);
            test3.Insert(5);
            test3.Insert(6);
            test3.Insert(7);

            Assert.Equal("[7] ->[6] ->[5] ->[4] ->[3] ->[2] ->[3] ->NULL", test3.Tostring());
        }




        [Fact]
        // if Will return true when finding a value within the linked list that exists
        public void Class05_Test_IndicatesReturn()
        {
            LinkedList test3 = new LinkedList(3);
            test3.Insert(2);
            test3.Insert(3);
            test3.Insert(4);
            test3.Insert(5);
            test3.Insert(6);
            test3.Insert(7);

            Assert.True(test3.Indicates(5));

        }


        [Fact]
        // if Will return false when searching for a value in the linked list that does not exist
        public void Class05_Test_IndicatesReturnFalse()
        {
            LinkedList test3 = new LinkedList(3);
            test3.Insert(2);
            test3.Insert(3);
            test3.Insert(4);
            test3.Insert(5);
            test3.Insert(6);
            test3.Insert(7);

            Assert.True(!test3.Indicates(10));

        }


        [Fact]
        // if Can properly return a collection of all the values that exist in the linked list
        public void Class05_Test_Tostring()
        {
            LinkedList test3 = new LinkedList(1);
            test3.Insert(4);
            test3.Insert(6);
            test3.Insert(8);
            test3.Insert(10);
            test3.Insert(12);
            test3.Insert(14);

            Assert.Equal("[14] ->[12] ->[10] ->[8] ->[6] ->[4] ->[1] ->NULL", test3.Tostring());

        }





        [Fact]
        // if Can successfully add a node to the end of the linked list
        public void Class06_Test_AddToEnd()
        {
            LinkedList test3 = new LinkedList(3);
            test3.AppendElement(2);



            Assert.Equal("[3] ->[2] ->NULL", test3.Tostring());

        }



        [Fact]
        // if Can successfully add multiple nodes to the end of a linked list
        public void Class06_Test_AddMultiple()
        {
            LinkedList test3 = new LinkedList(1);
            test3.AppendElement(2);
            test3.AppendElement(3);
            test3.AppendElement(4);
            test3.AppendElement(5);
            test3.AppendElement(6);
            test3.AppendElement(7);

            Assert.Equal("[1] ->[2] ->[3] ->[4] ->[5] ->[6] ->[7] ->NULL", test3.Tostring());

        }




        [Fact]
        // if Can successfully insert a node before the first node of a linked list
        public void Class06_Test_AddAfter()
        {
            LinkedList test3 = new LinkedList(1);
            test3.AppendElement(2);
            test3.AppendElement(3);
            test3.AppendElement(4);
            test3.AppendElement(5);
            test3.AppendElement(6);
            test3.AppendElement(7);
            test3.InsertAfter(9, 4);


            Assert.Equal("[1] ->[2] ->[3] ->[4] ->[9] ->[5] ->[6] ->[7] ->NULL", test3.Tostring());

        }
        [Fact]
        // if Can successfully insert a node before a node located i the middle of a linked list
        public void Class06_Test_AddBefore()
        {
            LinkedList test3 = new LinkedList(1);
            test3.AppendElement(2);
            test3.AppendElement(3);
            test3.AppendElement(4);
            test3.AppendElement(5);
            test3.AppendElement(6);
            test3.AppendElement(7);
            test3.InsertBefore(9, 4);


            Assert.Equal("[1] ->[2] ->[3] ->[9] ->[4] ->[5] ->[6] ->[7] ->NULL", test3.Tostring());

        }

        [Fact]
        // if Can successfully insert a node before a node located i the middle of a linked list
        public void Class06_Test_AddBeforeFirst()
        {
            LinkedList test3 = new LinkedList(1);
            test3.AppendElement(2);
            test3.AppendElement(3);
            test3.AppendElement(4);
            test3.AppendElement(5);
            test3.AppendElement(6);
            test3.AppendElement(7);
            test3.Insert(9);


            Assert.Equal("[9] ->[1] ->[2] ->[3] ->[4] ->[5] ->[6] ->[7] ->NULL", test3.Tostring());

        }
        [Fact]
        // if Can successfully insert after a node in the middle of the linked list
        public void Class06_Test_AddAfterMid()
        {

            LinkedList test3 = new LinkedList(1);
            test3.AppendElement(2);
            test3.AppendElement(3);
            test3.AppendElement(4);
            test3.AppendElement(5);
            test3.AppendElement(6);
            test3.AppendElement(7);
            test3.InsertAfter(9, 4);


            Assert.Equal("[1] ->[2] ->[3] ->[4] ->[9] ->[5] ->[6] ->[7] ->NULL", test3.Tostring());

        }



        [Fact]
        // if Can successfully insert a node after the last node of the linked list
        public void Class06_Test_AfterTheLast()
        {
            LinkedList test3 = new LinkedList(1);
            test3.AppendElement(2);
            test3.AppendElement(3);
            test3.AppendElement(4);
            test3.AppendElement(5);
            test3.AppendElement(6);
            test3.AppendElement(7);
            test3.InsertAfter(9, 7);


            Assert.Equal("[1] ->[2] ->[3] ->[4] ->[5] ->[6] ->[7] ->[9] ->NULL", test3.Tostring());

        }


    }
}
