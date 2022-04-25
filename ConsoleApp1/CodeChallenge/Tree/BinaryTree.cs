using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class BinaryTree
    {
        public BinaryTNode root { get; set; }
     

        public int findMaximum()
        {
            Queue<BinaryTNode> brethQueue = new Queue<BinaryTNode>();
            int max = root.Value;
            brethQueue.Enqueue(root);

            while (brethQueue.Count() != 0)
            {
                BinaryTNode front = brethQueue.Dequeue();

                if (front.Value > max)
                { max = front.Value; }
                if (front.Left != null)
                { brethQueue.Enqueue(front.Left); }
                if (front.Right != null)
                { brethQueue.Enqueue(front.Right); }
            }
            return max;
        }
    }
}
