using ConsoleApp1;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Program = ConsoleApp1.Program;

namespace TestProject1
{
    public class TreesTest
    {


        #region class 18: tree-fizz-buzz



        [Fact]
        public void Class18_CreatetreefizzbuzzTest()
        {
            
            K_aryTree k_aryTree = new K_aryTree();

            K_aryTNode rootNode = new K_aryTNode("50");
            K_aryTNode node1 = new K_aryTNode("30");
            K_aryTNode node2 = new K_aryTNode("10");
            K_aryTNode node11 = new K_aryTNode("115");
            K_aryTNode node12 = new K_aryTNode("5");
            K_aryTNode node13 = new K_aryTNode("16");
            K_aryTNode node21 = new K_aryTNode("12");
            K_aryTNode node22 = new K_aryTNode("49");


            rootNode.addChildren(node1);
            rootNode.addChildren(node2);
            node1.addChildren(node11);
            node1.addChildren(node12);
            node1.addChildren(node13);
            node2.addChildren(node21);
            node2.addChildren(node22);

            k_aryTree.root = rootNode;



            K_aryTree k_ary = Program.callFizzBuzzTree(k_aryTree);

            Console.Write(k_ary.root.Value + " ");
            string result="";

            foreach (K_aryTNode item in k_ary.root.Children)
            {
                result+= item.Value + " ";
            }


            Assert.Equal("Buzz fizzBuzz Buzz Buzz Buzz 16 fizz 49 ", result);

        }
        [Fact]
        public void Class18_CreateEmptytreefizzbuzzTest()
        {
         
            K_aryTree k_aryTree = new K_aryTree();

    

            K_aryTree k_ary = Program.callFizzBuzzTree(k_aryTree);

           


            Assert.Null(k_ary);

        }


        [Fact]
        public void Class18_CreatetreefizzbuzzTest2()
        {
            
            K_aryTree k_aryTree = new K_aryTree();

            K_aryTNode rootNode = new K_aryTNode("12");
            K_aryTNode node1 = new K_aryTNode("18");
            K_aryTNode node2 = new K_aryTNode("15");
            K_aryTNode node11 = new K_aryTNode("56");
            K_aryTNode node12 = new K_aryTNode("0");
            K_aryTNode node13 = new K_aryTNode("6");
            K_aryTNode node21 = new K_aryTNode("16");
            K_aryTNode node22 = new K_aryTNode("33");


            rootNode.addChildren(node1);
            rootNode.addChildren(node2);
            node1.addChildren(node11);
            node1.addChildren(node12);
            node1.addChildren(node13);
            node2.addChildren(node21);
            node2.addChildren(node22);

            k_aryTree.root = rootNode;



            K_aryTree k_ary = Program.callFizzBuzzTree(k_aryTree);

            Console.Write(k_ary.root.Value + " ");
            string result = "";

            foreach (K_aryTNode item in k_ary.root.Children)
            {
                result += item.Value + " ";
            }


            Assert.Equal("fizz fizz fizzBuzz 56 fizzBuzz fizz 16 fizz ", result);

        }



        #endregion




        #region call Class 15: trees

        [Fact]
        /// test if can create empty tree
        public void Class15_CreateEmptyBTreeTest()
        {
            BinaryTree binaryTree = new BinaryTree();


            Assert.Null(binaryTree.root);

        }

        [Fact]
        /// test if can create empty tree
        public void Class15_CreateEmptyBSTreeTest()
        {
            BSTree binarysearchTree = new BSTree();


            Assert.Null(binarysearchTree.root);

        }

    

        [Fact]
        /// test if can create tree with root
        public void Class15_CreateBSTreeWithRootTest()
        {
            BSTree bsTree = new BSTree();

            bsTree.add(12);

            Assert.Equal(12, bsTree.root.Value);
            //Assert.True(bsTree.contains(12));
        }

        [Fact]
        /// test if can data fit correctly in the right of BStree 
        public void Class15_CreateBSTreeWithDataRightTest2()
        {
            BSTree bsTree = new BSTree();

            bsTree.add(12);

            bsTree.add(6);

            bsTree.add(15);

            Assert.Equal(15, bsTree.root.Right.Value);
        
        }


        [Fact]
        /// test if can data fit correctly in the lift of BStree 
        public void Class15_CreateBSTreeWithDataLiftTest2()
        {
            BSTree bsTree = new BSTree();

            bsTree.add(12);

            bsTree.add(6);

            bsTree.add(15);

            Assert.Equal(6, bsTree.root.Left.Value);
         
        }


        [Fact]
        /// test if can return the correct Depth First Pre Order
        public void Class15_DepthFirstPreOrderTest1()
        {
            string result = null;
            BinaryTree binaryTree = new BinaryTree();

            BinaryTNode node21 = new BinaryTNode(21, null, null);
            BinaryTNode node12 = new BinaryTNode(12, null, null);
            BinaryTNode node11 = new BinaryTNode(11, null, null);
            BinaryTNode node2 = new BinaryTNode(2, node21, null);
            BinaryTNode node1 = new BinaryTNode(1, node11, node12);
            BinaryTNode rootNode = new BinaryTNode(0, node1, node2);

            binaryTree.root = rootNode;

            foreach (var item in binaryTree.preOrder())
            {
                result = result + item.ToString() + " ";
            }

            Assert.Equal("0 1 11 12 2 21 ", result);
        }


        [Fact]
        /// test if can return the correct Depth First inOrder
        public void Class15_DepthFirstinOrderTest()
        {
            string result = null;
            BinaryTree binaryTree = new BinaryTree();

            BinaryTNode node21 = new BinaryTNode(21, null, null);
            BinaryTNode node12 = new BinaryTNode(12, null, null);
            BinaryTNode node11 = new BinaryTNode(11, null, null);
            BinaryTNode node2 = new BinaryTNode(2, node21, null);
            BinaryTNode node1 = new BinaryTNode(1, node11, node12);
            BinaryTNode rootNode = new BinaryTNode(0, node1, node2);

            binaryTree.root = rootNode;

            foreach (var item in binaryTree.inOrder())
            {
                result +=item+ " ";
            }

            Assert.Equal("11 1 12 0 21 2 ", result);
        }
        [Fact]
        /// test if can return the correct Depth First postOrder
        public void Class15_DepthFirstPostOrderTest1()
        {
            string result = null;
            BinaryTree binaryTree = new BinaryTree();

            BinaryTNode node21 = new BinaryTNode(21, null, null);
            BinaryTNode node12 = new BinaryTNode(12, null, null);
            BinaryTNode node11 = new BinaryTNode(11, null, null);
            BinaryTNode node2 = new BinaryTNode(2, node21, null);
            BinaryTNode node1 = new BinaryTNode(1, node11, node12);
            BinaryTNode rootNode = new BinaryTNode(0, node1, node2);

            binaryTree.root = rootNode;

            foreach (var item in binaryTree.postOrder())
            {
                result += item + " ";
            }

            Assert.Equal("11 12 1 21 2 0 ", result);
        }

        [Fact]
        /// test if can method contains BStree 
        public void Class15_CreateBSTreeContainsMethodTest1()
        {
            BSTree bsTree = new BSTree();

            bsTree.add(12);

            bsTree.add(6);

            bsTree.add(15);

            bsTree.add(11);

            bsTree.add(14);

            bsTree.add(29);


            Assert.True( bsTree.contains(12));

        }
        [Fact]
        /// test if can method contains BStree 
        public void Class15_CreateBSTreeContainsMethodTest2()
        {
            BSTree bsTree = new BSTree();

            bsTree.add(12);

            bsTree.add(6);

            bsTree.add(15);

            bsTree.add(11);

            bsTree.add(14);

            bsTree.add(29);


            Assert.True( ! bsTree.contains(30));

        }




        #endregion
        #region call Class 17: tree-breadth-first

        [Fact]
        /// test if can return the correct tree
        public void Class17_breadthFirstTest1()
        {
            string result = null;

            TreeNode node21 = new TreeNode(2);
            TreeNode node12 = new TreeNode(2);
            TreeNode node11 = new TreeNode(2);
            TreeNode node2 = new TreeNode(1);
            TreeNode node1 = new TreeNode(1);
            TreeNode rootNode = new TreeNode(0);

            rootNode.children.Add(node1);
            rootNode.children.Add(node2);
            node1.children.Add(node11);
            node1.children.Add(node12);
            node2.children.Add(node21);


            foreach (var item in Program.breadthFirst(rootNode))
            {
                result = result + item.ToString() + " ";
            }

            Assert.Equal("0 1 1 2 2 2 ", result);
        }

        [Fact]
        /// test if can return the correct tree
        public void Class17_breadthFirstTest2()
        {
            string result = null;
            
            TreeNode node21 = new TreeNode(15);
            TreeNode node12 = new TreeNode(5);
            TreeNode node11 = new TreeNode(115);
            TreeNode node2 = new TreeNode(10);
            TreeNode node1 = new TreeNode(30);
            TreeNode rootNode = new TreeNode(50);

            rootNode.children.Add(node1);
            rootNode.children.Add(node2);
            node1.children.Add(node11);
            node1.children.Add(node12);
            node2.children.Add(node21);


            foreach (var item in Program.breadthFirst(rootNode))
            {
                result = result+ item.ToString() +" ";
            }

            Assert.Equal("50 30 10 115 5 15 ",result); 

        }


        [Fact]
        /// test if can return the correct tree
        public void Class17_breadthFirstTest3()
        {
            string result = null;

            TreeNode node211 = new TreeNode(211);
            TreeNode node212 = new TreeNode(212);
            TreeNode node213 = new TreeNode(213);
            TreeNode node21 = new TreeNode(21);
            TreeNode node13 = new TreeNode(13);
            TreeNode node12 = new TreeNode(12);
            TreeNode node11 = new TreeNode(11);
            TreeNode node2 = new TreeNode(2);
            TreeNode node1 = new TreeNode(1);
            TreeNode rootNode = new TreeNode(0);

            rootNode.children.Add(node1);
            rootNode.children.Add(node2);
            node1.children.Add(node11);
            node1.children.Add(node12);
            node1.children.Add(node13);
            node2.children.Add(node21);
            node21.children.Add(node211);
            node21.children.Add(node212);
            node21.children.Add(node213);
            foreach (var item in Program.breadthFirst(rootNode))
            {
                result = result + item.ToString() + " ";
            }

            Assert.Equal("0 1 2 11 12 13 21 211 212 213 ", result);

        }


        #endregion

        #region Class 16: tree-max
        ///Class 16: tree-max
        ///
        [Fact]
        /// test if can create empty tree
        public void Class16_CreateEmptyTest()
        {
            BinaryTree binaryTree = new BinaryTree();


            Assert.Null(binaryTree.root);

        }
        [Fact]
        /// test if can return the correct max 
        public void Class16_MaxTest1()
        {
            BinaryTree binaryTree = new BinaryTree();

            BinaryTNode node21 = new BinaryTNode(15, null, null);
            BinaryTNode node12 = new BinaryTNode(5, null, null);
            BinaryTNode node11 = new BinaryTNode(115, null, null);
            BinaryTNode node2 = new BinaryTNode(120, node21, null);
            BinaryTNode node1 = new BinaryTNode(30, node11, node12);
            BinaryTNode rootNode = new BinaryTNode(50, node1, node2);

            binaryTree.root = rootNode;

           Assert.Equal(120, binaryTree.findMaximum());
        }
        [Fact]
        ///  test if can return the correct max if there is two max value
        public void Class16_MaxTest2()
        {
            BinaryTree binaryTree = new BinaryTree();

       
            BinaryTNode node21 = new BinaryTNode(130, null, null);
            BinaryTNode node12 = new BinaryTNode(5, null, null);
            BinaryTNode node11 = new BinaryTNode(130, null, null);
            BinaryTNode node2 = new BinaryTNode(10, node21, null);
            BinaryTNode node1 = new BinaryTNode(30, node11, node12);
            BinaryTNode rootNode = new BinaryTNode(50, node1, node2);

            binaryTree.root = rootNode;

            Assert.Equal(130, binaryTree.findMaximum());
        }
        [Fact]
        /// test if can return the correct max if all is a negative numvers
        public void Class16_MaxTest3()
        {
            BinaryTree binaryTree = new BinaryTree();

         
            BinaryTNode node21 = new BinaryTNode(-15, null, null);
            BinaryTNode node12 = new BinaryTNode(-5, null, null);
            BinaryTNode node11 = new BinaryTNode(-115, null, null);
            BinaryTNode node2 = new BinaryTNode(-10, node21, null);
            BinaryTNode node1 = new BinaryTNode(-30, node11, node12);
            BinaryTNode rootNode = new BinaryTNode(-50, node1, node2);

            binaryTree.root = rootNode;

            Assert.Equal(-5, binaryTree.findMaximum());

        }
        [Fact]
        /// test if can return the correct max with more hight
        public void Class16_MaxTest4()
        {
            BinaryTree binaryTree = new BinaryTree();


            BinaryTNode node212 = new BinaryTNode(150, null, null);
            BinaryTNode node211 = new BinaryTNode(30, null, null);
            BinaryTNode node122 = new BinaryTNode(40, null, null);
            BinaryTNode node21 = new BinaryTNode(15, node211, node212);
            BinaryTNode node12 = new BinaryTNode(5, null, node122);
            BinaryTNode node11 = new BinaryTNode(115, null, null);
            BinaryTNode node2 = new BinaryTNode(10, node21, null);
            BinaryTNode node1 = new BinaryTNode(30, node11, node12);
            BinaryTNode rootNode = new BinaryTNode(50, node1, node2);

            binaryTree.root = rootNode;

            Assert.Equal(150, binaryTree.findMaximum());

        }
    #endregion
}
}
