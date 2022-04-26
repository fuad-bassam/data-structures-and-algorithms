using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    // class 15: tress
    public class BSTree
    {

        // class 15: tress

        public BinaryTNode root { get; set; }


        public void add(int value)
        {

            BinaryTNode newNode = new BinaryTNode(value);

            if (root == null)
            {
                root = newNode;
                return;
            } 

            BinaryTNode searchNode = root;
            if (root == null) {

                Console.WriteLine("the tree is empty");
                return;
            }

            while (searchNode.Left != null || searchNode.Right != null) {

                if (searchNode.Value >= newNode.Value)
                { if (searchNode.Left != null)
                    { searchNode = searchNode.Left; }
                    else
                    { break; } }
                else {
                    if (searchNode.Right != null)
                    {
                        searchNode = searchNode.Right;
                    }
                    else
                    { break; }
                }
            }

            if (searchNode.Value > newNode.Value) {
                searchNode.Left = newNode;
                Console.WriteLine($"added node {newNode.Value} to Left of {searchNode.Value}");
            }

            else
            { searchNode.Right = newNode;
                Console.WriteLine($"added node {newNode.Value} to Right of {searchNode.Value}");
            } }
        public bool contains(int value)
        { BinaryTNode searchNode = root;


            while (searchNode.Left != null || searchNode.Right != null)
            {

                if (searchNode.Value > value)

                { return true; }

                if (searchNode.Value > value)
                {
                    if (searchNode.Left != null) 

                        { searchNode = searchNode.Left; }
                    else
                      { break; } }
                else
                {
                 if (searchNode.Right != null) 
                    {searchNode = searchNode.Right; }
                  else { break; }

                } 
            }
                return false;


        }

        public void addRoot(BinaryTNode addedRoot) {

            root = addedRoot;
        
        }

    }
}
