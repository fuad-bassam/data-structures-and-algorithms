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


        #region class 15 : trees

        public List<int> datalist = new List<int>();


        public void preOrderAlog(BinaryTNode root)
        {
            BinaryTNode searchNode = root;


            datalist.Add(root.Value);

            if (root.Left != null)
            { preOrderAlog(root.Left); }

            if (root.Right != null)
            { preOrderAlog(root.Right); }

        }
        ///--------
        public Array preOrder()
        {
            preOrderAlog(root);
            Array datalArray = datalist.ToArray();
            datalist.Clear();
            return datalArray;
        }

        public void inOrderAlog(BinaryTNode root)
        {
            BinaryTNode searchNode = root;


            

            if (root.Left != null)
            { inOrderAlog(root.Left); }

            datalist.Add(root.Value);

            if (root.Right != null)
            { inOrderAlog(root.Right); }

        }
        ///--------
        public Array inOrder()
        {
            inOrderAlog(root);
            Array datalArray = datalist.ToArray();
            datalist.Clear();
            return datalArray;
        }

        public void postOrderAlog(BinaryTNode root)
        {
            BinaryTNode searchNode = root;

            if (root.Left != null)
            { postOrderAlog(root.Left); }

            

            if (root.Right != null)
            { postOrderAlog(root.Right); }
            datalist.Add(root.Value);
        }
        ///--------
        public Array postOrder()
        {
            postOrderAlog(root);
            Array datalArray = datalist.ToArray();
            datalist.Clear();
            return datalArray;
        }


        #endregion







        #region class 16

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
        #endregion
    


}

} 
