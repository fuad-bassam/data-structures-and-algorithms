using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class K_aryTNode
    {
        public string Value { get; set; }

        
        public K_aryTNode Right { get; set; }
        public K_aryTNode Left { get; set; }

        public K_aryTNode(string value , K_aryTNode left , K_aryTNode right)
        {
            this.Value = value;
            this.Left = left;
            this.Right = right;
          
        }
        public K_aryTNode(string value)
        {
            this.Value = value;
           
        }
       
    }
}
