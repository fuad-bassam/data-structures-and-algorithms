using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BinaryTNode
    {
        public int Value { get; set; }

        public BinaryTNode Right { get; set; }
        public BinaryTNode Left { get; set; }

        public BinaryTNode(int value , BinaryTNode left , BinaryTNode right)
        {
            this.Value = value;
            this.Left = left;
            this.Right = right;
          
        }
        public BinaryTNode(int value)
        {
            this.Value = value;
           
        }
       
    }
}
