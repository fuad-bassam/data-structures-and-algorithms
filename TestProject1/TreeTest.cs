using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestProject1
{
    public class TreeTest
    {

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
    }
}
