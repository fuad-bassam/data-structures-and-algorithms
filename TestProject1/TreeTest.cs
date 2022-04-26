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
    public class TreeTest
    {
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
