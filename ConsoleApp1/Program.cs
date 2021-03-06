using CodeChallenge.CodeChallenge.Graphs;
using CodeChallenge.CodeChallenge.Hash;
using ConsoleApp1.codeCha;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{

    public class Program
    {


        public static void arrayIntElementToConsole(int[] arr)
        {




            Console.Write("The Result :- { ");

            foreach (int i in arr)
            {

                Console.Write(i + " ");
            }

            Console.WriteLine("} \n");


        }



        #region Lab 14: stack-queue-brackets
        public static string DDGgame(Queue<String> queue1, int key)
        {
            Queue<String> queue2 = new Queue<string>();
            int count = 0; bool turn = true;


            while (queue1.Count + queue2.Count != 1)
            {
                count = key;
                while (count != 0)
                {
                    if (turn)
                    {

                        queue2.Enqueue(queue1.Dequeue());
                        count--;
                    }
                    else
                    {
                        queue1.Enqueue(queue2.Dequeue());
                        count--;
                    }
                    if (queue1.Count == 0 || queue2.Count == 0)
                    { turn = !turn; }
                }
                if (turn)
                { Console.WriteLine(queue2.Dequeue()); }
                else
                { Console.WriteLine(queue1.Dequeue()); }
            }
            if (queue1.Peek() == null)
            { return queue2.Peek(); }
            else
            { return queue1.Peek(); }


        }

        #endregion

        #region Class 13: stack-queue-brackets

        public static bool validateBrackets(string str)
        {
            Stack stack = new Stack();
            foreach (char item in str)
            {
                if (item == '[' || item == '(' || item == '{')
                {
                    stack.push(item.ToString());
                }
                if (item == ']' || item == ')' || item == '}')
                {
                    string x;
                    if (item == ']')
                    {
                        x = "[";
                    } else if (item == ')')
                    {
                        x = "(";
                    } else
                    {
                        x = "{";
                    }

                    if (stack.peek() == x)
                    {
                        stack.pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            if (stack.peek() == "Stack is empty !!")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region call-linked-list
        ////////// call-Challenge5-linked-list
        public static void Call_LinkedList() {
            try
            {
                LinkedList linkl = new LinkedList();
                linkl.insert("8");
                linkl.insert("6");
                linkl.insert("4");
                linkl.appendElement("12");
                linkl.insertAfter("13", "6");
                linkl.insertBefore("15", "4");
                Console.Write(linkl.toString());
                Console.WriteLine($"is there {4} " + linkl.indicates("4"));
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

        }
        #endregion

        #region call-linked-list
        ////////// call-Challenge6-linked-list
        public static void Call_LinkedList2()
        {
            try
            {
                LinkedList linkl = new LinkedList();

                linkl.appendElement("12");
                linkl.appendElement("11");
                linkl.appendElement("10");
                linkl.appendElement("9");
                linkl.appendElement("8");
                linkl.insertAfter("13", "16");
                //  linkl.insertBefore(15, 12);
                Console.Write(linkl.toString());

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

        }
        #endregion

        #region call-linked-list-kth
        //call-Challenge7-linked-list-kth

        public static void Call_LinkedList3()
        {
            try
            {
                LinkedList linkl = new LinkedList();

                linkl.appendElement("12");
                linkl.appendElement("11");
                linkl.appendElement("10");
                linkl.appendElement("9");
                linkl.appendElement("8");


                //  Console.Write(linkl.toString());
                Console.WriteLine("the value is " + linkl.kthFromEnd(3));
                Console.WriteLine("the value is " + linkl.kthFromEnd(0));

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

        }
        #endregion

        #region call-linked-list-zip

        //call-Challenge8-linked-list-zip 


        public static LinkedList zipList(LinkedList list1, LinkedList list2)
        {
            LinkedList list3 = list1.deepcopy();
            LinkedList list4 = (LinkedList)list2.deepcopy();
            Node pointer = list3.FirstNode;
            Node selectNode;

            if (pointer == null)
                return list4;




            while (pointer != null)
            {
                if (list4.FirstNode != null)
                {
                    selectNode = list4.FirstNode;


                    list4.FirstNode = list4.FirstNode.next;


                    selectNode.next = pointer.next;
                    pointer.next = selectNode;

                    if (pointer.next.next == null && list4.FirstNode != null)
                    {
                        pointer.next.next = list4.FirstNode;
                        return list3;
                    }



                    pointer = pointer.next.next;
                }
                else
                {
                    return list3;
                }

            }





            return list3;
        }
        #endregion

        #region Class 17: tree-breadth-first
        public static List<int> breadthFirst(TreeNode root)
        {
            Queue<TreeNode> brethQueue = new
            Queue<TreeNode>();
            List<int> brethList = new List<int>();

            brethQueue.Enqueue(root);
            while (brethQueue.Count() != 0)
            {
                TreeNode front = brethQueue.Dequeue();

                brethList.Add(front.Value);

                foreach (TreeNode node in front.children)
                {
                    brethQueue.Enqueue(node);
                }


                // in Binary tree

                //if (front.Left != null)
                //{ brethQueue.Enqueue(front.Left); }
                //if (front.Right != null)
                //{ brethQueue.Enqueue(front.Right); }
            }
            return brethList;
        }


        #endregion

        #region class 18: tree-fizz-buzz

        public static string BuzzTreeCheck(K_aryTNode node)
        {
            string val;
            int nodeInt = Int32.Parse(node.Value);
            if (nodeInt % 5 == 0 && nodeInt % 3 == 0)
                val = "fizzBuzz";
            else if (nodeInt % 5 == 0)
                val = "Buzz";
            else if (nodeInt % 3 == 0)
                val = "fizz";
            else
                val = node.Value.ToString();

            return val;
        }
        public static void fizzBuzzTree(K_aryTNode root, K_aryTNode newtreeRoot)
        {


            Queue<K_aryTNode> brethQueue = new Queue<K_aryTNode>();

            brethQueue.Enqueue(root);
            while (brethQueue.Count() != 0)
            {
                K_aryTNode front = brethQueue.Dequeue();
                string val = BuzzTreeCheck(front);
                front.Value = val;


                newtreeRoot.addChildren(front);



                foreach (K_aryTNode node in front.Children)
                {
                    brethQueue.Enqueue(node);
                }

            }

        }
        public static K_aryTree callFizzBuzzTree(K_aryTree k_aryTree)
        {
            K_aryTree newK_aryTree = new K_aryTree();

            if (k_aryTree.root == null)
            {
                return null;
            }

            string val = BuzzTreeCheck(k_aryTree.root);
            K_aryTNode root = new K_aryTNode(val);
            newK_aryTree.root = root;


            fizzBuzzTree(k_aryTree.root, newK_aryTree.root);

            return newK_aryTree;
        }


        #endregion

        #region class26: InsertionSort
        public static int[] InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int j = i - 1;
                int mid = arr[i];

                while (j >= 0 && mid < arr[j])
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                    arr[j + 1] = mid;
                }
            }
            return arr;

        }
        #endregion

        #region class27: Merge Sort


        public static int[] MergeSort(int[] arr)
        { int n = arr.Length;

            if (n > 1)
            {
                int mid = n / 2;
                int[] left = arr.Take(mid).ToArray();
                int[] right = arr.Skip(mid).ToArray();

                MergeSort(left);

                MergeSort(right);

                int[] arr2 = Merge(left, right, arr);
                return arr2;
            }
            else {
                return arr;
            }
        }

        public static int[] Merge(int[] left, int[] right, int[] arr) {
            int i = 0;
            int j = 0;
            int k = 0;

            while (i < left.Length && j < right.Length)
            { if (left[i] <= right[j])
                { arr[k] = left[i];
                    i += 1; }
                else
                { arr[k] = right[j];
                    j += 1; }

                k += 1;
            }


            while (i < left.Length)
            {
                arr[k] = left[i];
                k++;
                i++;
            }
            while (j < right.Length)
            {
                arr[k] = right[j];
                k++;
                j++;
            }
            return arr;
        }



        #endregion

        #region class28: Quick Sort


        public static void QuickSort(int[] arr, int left, int right) {
            if (left < right) {
                int position = Partition(arr, left, right);
                QuickSort(arr, left, position - 1);
                QuickSort(arr, position + 1, right);
            } }

        public static int Partition(int[] arr, int left, int right) {
            int pivot = arr[right];
            int low = left - 1;
            for (int i = left; i < right; i++) {
                if (arr[i] <= pivot)
                {
                    low++;
                    Swap(arr, i, low);
                }
            }
            Swap(arr, right, low + 1);
            return low + 1;
        }

        public static void Swap(int[] arr, int i, int low) {
            int temp;
            temp = arr[i];


            arr[i] = arr[low];


            arr[low] = temp;
        }

        #endregion

        #region class31 :hashmap-repeated-word

        public static string repeatedWord(string string1)
        {
            String string2 = string1.Replace(",", "").ToLower();
            string[] listWord = string2.Split(' ');

            for (int i = 0; i < listWord.Length && listWord.Length > 1; i++)
            {
                for (int j = i; j >= 0; j--)
                {
                    if (listWord[i + 1] == listWord[j])
                    { return listWord[i + 1]; }
                }
            }
            return null;
        }
        #endregion

        #region class33 :hashmap leftJoin

        public class HashJoinTable
        {
            public string key { get; set; }
            public int? table1Data { get; set; }
            public int? table2Data { get; set; }

            //public HashJoinTable(string key, int? table1Data, int? table2Data)
            //{
            //    this.key = key;
            //    this.table1Data = table1Data;
            //    this.table2Data = table2Data;
            //}
        }
        public static List<HashJoinTable> addhashTableData(HashTable table, HashTable table2)
        {
            List<HashJoinTable> newTable = new List<HashJoinTable>();

            foreach (string item in table.arrayKey)
            {
                if (item == null)
                {
                    continue;
                }

                int indexHash = table.hash(item);

                newTable.Add(new HashJoinTable { key = item, table1Data = table.arrayvalue[indexHash], table2Data = table2.arrayvalue[indexHash] });

                table2.arrayKey[indexHash] = null;
                //  newJoinTable.Add(new HashJoinTable { item, table1.arrayvalue[indexHash], table2.arrayvalue[indexHash] });

            }

            return newTable;

        }

        public static List<HashJoinTable> hashmapLeftJoin(HashTable table1, HashTable table2)
        {

            List<HashJoinTable> newHashJoinTable = new List<HashJoinTable>();


            newHashJoinTable.AddRange(addhashTableData(table1, table2));

            newHashJoinTable.AddRange(addhashTableData(table2, table1));


            return newHashJoinTable;
        }
        #endregion
        #region class32 :tree-intersection

        //DATA From class 15

        public static List<BinaryTree> demoTreeData() {

            BinaryTree tree1 = new BinaryTree();

            BinaryTNode node21 = new BinaryTNode(15, null, null);
            BinaryTNode node12 = new BinaryTNode(5, null, null);
            BinaryTNode node11 = new BinaryTNode(115, null, null);
            BinaryTNode node2 = new BinaryTNode(15, node21, null);
            BinaryTNode node1 = new BinaryTNode(24, node11, node12);
            BinaryTNode rootNode = new BinaryTNode(50, node1, node2);

            tree1.root = rootNode;

            BinaryTree tree2 = new BinaryTree();

            BinaryTNode tree2Node21 = new BinaryTNode(1, null, null);
            BinaryTNode tree2Node12 = new BinaryTNode(5, null, null);
            BinaryTNode tree2Node11 = new BinaryTNode(115, null, null);
            BinaryTNode tree2Node2 = new BinaryTNode(13, tree2Node21, null);
            BinaryTNode tree2Node1 = new BinaryTNode(25, tree2Node11, tree2Node12);
            BinaryTNode tree2rootNode = new BinaryTNode(50, tree2Node1, tree2Node2);

            tree2.root = tree2rootNode;



            List<BinaryTree> ListTrees = new List<BinaryTree>();
            ListTrees.Add(tree1);
            ListTrees.Add(tree2);

            return ListTrees;
        }



        public static List<int> tree_intersection(BinaryTree tree1, BinaryTree tree2) {

            if (tree1 == null || tree2 == null || tree1.root == null || tree2.root == null)
            {
                return null;
            }

            HashTable hashTable1 = new HashTable();
            List<int> listData = new List<int>();

            Array treeArray1 = tree1.preOrder();

            foreach (int item in treeArray1)
            {
                hashTable1.set(item.ToString(), item);
            }

            Array treeArray2 = tree2.preOrder();

            foreach (int item in treeArray2)
            {
                if (hashTable1.get(item.ToString()) != null)
                {
                    listData.Add(item);
                }

            }


            return listData;
        }
        #endregion

        #region class37 : graph-business-trip  
        public static decimal? businesstrip(Graphs graph, string[] cityNames)
        {   decimal totalCost = 0, checkTotalCost = 0;

            for (int cityIndex = 0; cityIndex < cityNames.Length; cityIndex++)
            {
                GraphNode cityNode = graph.getNodes().FirstOrDefault(x => x.value == cityNames[cityIndex]);
                if (cityNode == null)
                { return null; }
                checkTotalCost = totalCost;

                foreach (GraphNodeEdges edge in cityNode.Edges)
                {
                    if (cityIndex+1 >= cityNames.Length)
                    {
                        continue;
                    }else if ( edge.node2.value == cityNames[cityIndex + 1])
                    {
                        totalCost += edge.edgeWeight;
                        break;
                    }
                }


                if (checkTotalCost == totalCost && cityIndex + 1 < cityNames.Length)
                { return null; }
            }
                return totalCost;
            
        }
            #endregion

        static void Main(string[] args)
        {
            #region class 38: graph-depth-first
            Graphs graphs = new Graphs();

            GraphNode node1 = graphs.add("amman");
            GraphNode node2 = graphs.add("zarqa");
            GraphNode node3 = graphs.add("irbed");
            GraphNode node4 = graphs.add("aqaba");
            GraphNode node5 = new GraphNode("karak");

            graphs.addEdge(node1, node2, 10);
            graphs.addEdge(node2, node1, 3);
            graphs.addEdge(node1, node3, 4);
            graphs.addEdge(node3, node4, 20);
            graphs.addEdge(node2, node3, 15);
            graphs.addEdge(node1, node3, 4);

            string[] trip = { "amman", "zarqa", "irbed", "aqaba" };

            Console.Write("the result=[ "); 


            foreach (var item in graphs.depthFirst(node1))
            {
                Console.Write("" + item+"  ");

            }
            Console.Write("]");


            #endregion

            #region class37 : graph-business-trip

            //Graphs graphs = new Graphs();

            //GraphNode node1 = graphs.add("amman");
            //GraphNode node2 = graphs.add("zarqa");
            //GraphNode node3 = graphs.add("irbed");
            //GraphNode node4 = graphs.add("aqaba");
            //GraphNode node5 = graphs.add("amman");

            //graphs.addEdge(node1, node2, 10);
            //graphs.addEdge(node2, node1, 3);
            //graphs.addEdge(node1, node3, 4);
            //graphs.addEdge(node3, node4, 20);
            //graphs.addEdge(node2, node3, 15);
            //graphs.addEdge(node1, node3, 4);

            //string[] trip = { "amman", "zarqa", "irbed", "aqaba"};

            // Console.WriteLine("the value = "+businesstrip(graphs,trip));



            #endregion


            #region class36 : graph-breadth-first

            //Graphs graphs = new Graphs();

            //GraphNode node1 = graphs.add("5");
            //GraphNode node2 = graphs.add("10");
            //GraphNode node3 = graphs.add("15");
            //GraphNode node4 = graphs.add("20");
            //graphs.addEdge(node1, node2, 5);
            //graphs.addEdge(node2, node2, 3);
            //graphs.addEdge(node1, node3, 4);
            //graphs.addEdge(node3, node4, 8);
            //graphs.addEdge(node1, node2, 5);
            //graphs.addEdge(node2, node2, 3);
            //graphs.addEdge(node1, node3, 4);
            //graphs.addEdge(node3, node4, 8);

            //Console.WriteLine("The Graph node order {");
            //int countGraphNode = 0;

            //foreach (GraphNode node in graphs.breadthfirst())
            //{

            //    Console.WriteLine($"node {++countGraphNode} with value {node.value}");

            //}
            //Console.WriteLine("}");

            #endregion
            #region class35 :Graphs

            //Graphs graphs = new Graphs();

            //GraphNode node1 = graphs.add("5");
            //GraphNode node2 = graphs.add("10");
            //GraphNode node3 = graphs.add("15");
            //GraphNode node4 = graphs.add("20");
            //graphs.addEdge(node1, node2, 5);
            //graphs.addEdge(node2, node2, 3);
            //graphs.addEdge(node1, node3, 4);
            //graphs.addEdge(node3, node4, 8);

            //Console.WriteLine("The Graph have {");
            //int countGraphNode = 0;

            //foreach (GraphNode node in graphs.getNodes())
            //{

            //    Console.WriteLine($"node {++countGraphNode} with value {node.value}");

            //}
            //Console.WriteLine("}");

            #endregion


            #region class32 :tree-intersection


            //List<BinaryTree> demoData = demoTreeData();


            //List<int> resultList = tree_intersection(demoData[0], demoData[1]);
            //Console.Write($"\nThe result = ");

            //foreach (int item in resultList)
            //{
            //    Console.Write($"{item}|");
            //} ;
            #endregion


            #region class33 :hashmap leftJoin
            //HashTable hashTable1 = new HashTable ();
            //hashTable1.set("first",1 );
            //hashTable1.set("second", 2);
            //hashTable1.set("therd", 3);
            //hashTable1.set("the 6th", 6);
            //HashTable hashTable2 = new HashTable ();
            //hashTable2.set("first", 1);
            //hashTable2.set("second", 2);
            //hashTable2.set("therd", 3);
            //hashTable2.set("the forth", 4);

            //var listData=   hashmapLeftJoin(hashTable1 ,hashTable2);

            //Console.WriteLine("\n the");  

            //foreach (HashJoinTable item in listData)
            //{


            //    Console.WriteLine(item.key + ": " + item.table1Data +", " + item.table2Data );

            //    //Console.WriteLine(item.key +": "+ 
            //    //    item.table1Data != null? item.table1Data : "null" +
            //    //    ", " + item.table2Data != null ? item.table2Data : "null");

            //}
            #endregion
            #region class31 :hashmap-repeated-word

            //  string paragraph = "Once upon a time, there was a brave princess who...";

            //  string paragraph = "It was a queer, sultry summer , the summer they electrocuted the Rosenbergs, and I didn’t know what I was doing in New York...";
            //Console.WriteLine(repeatedWord(paragraph));

            #endregion
            #region class30: HashTable

            //HashTable hashTable = new HashTable();

            //hashTable.set("s" ,15);
            //hashTable.set("ss", 25);
            //hashTable.set("as", 55);
            //Console.WriteLine("the value for ss is = "+hashTable.get("sss"));
            ////if (hashTable.contains("sda"))
            ////{
            ////    Console.WriteLine("the data is "+ hashTable.get("sds"));
            ////}
            ////else { Console.WriteLine("no data"); }


            #endregion
            #region class28: Quick Sort

            //int[] arr = { 1, 6, 30, 4, 50, 13, 7 };

            //QuickSort(arr,0,arr.Length-1);

            //foreach (int item in arr)
            //{
            //    Console.Write(item + "   ");
            //}

            #endregion
            #region class27: Merge Sort


            //int[] arr = { 1, 6, 30, 4, 50, 13 ,7};

            //int[] arr2 = MergeSort(arr);

            //foreach (int item in arr2)
            //{
            //    Console.Write(item + "   ");
            //}

            #endregion
            #region class26: InsertionSort

            //int[] arr = { 1, 6, 30, 4,50,13 };

            // int[] arr2 = InsertionSort(arr);

            //foreach (int item in arr2)
            //{
            //    Console.Write(item+"   "   );
            //}

            #endregion
            #region class 18: tree-fizz-buzz

            //  Console.WriteLine("tree fizz buzz brethQueue ");
            //  K_aryTree k_aryTree = new K_aryTree();

            //  K_aryTNode rootNode = new K_aryTNode("50");
            //  K_aryTNode node1 = new K_aryTNode("30");
            //  K_aryTNode node2 = new K_aryTNode("10");
            //  K_aryTNode node11 = new K_aryTNode("115");
            //  K_aryTNode node12 = new K_aryTNode("5");
            //  K_aryTNode node13 = new K_aryTNode("16");
            //  K_aryTNode node21 = new K_aryTNode("12");
            //  K_aryTNode node22 = new K_aryTNode("49");


            //  rootNode.addChildren(node1);
            //  rootNode.addChildren(node2);
            //  node1.addChildren(node11);
            //  node1.addChildren(node12);
            //  node1.addChildren(node13);
            //  node2.addChildren(node21);
            //  node2.addChildren(node22);

            //  k_aryTree.root = rootNode;



            // K_aryTree k_ary = callFizzBuzzTree(k_aryTree);

            ////  Console.Write(k_ary.root.Value + " ");


            //  foreach (K_aryTNode item in k_ary.root.Children)
            //  {
            //      Console.WriteLine(item.Value + " ");
            //  }



            #endregion
            #region class 15 :trees
            // Console.WriteLine("Depth First as preOrder");
            // BinaryTree binaryTree = new BinaryTree();

            // ///// add element to tree like image in README file (Tree DATA)

            // BinaryTNode node21 = new BinaryTNode(15, null, null);
            // BinaryTNode node12 = new BinaryTNode(5, null, null);
            // BinaryTNode node11 = new BinaryTNode(115, null, null);
            // BinaryTNode node2 = new BinaryTNode(10, node21, null);
            // BinaryTNode node1 = new BinaryTNode(30, node11, node12);
            // BinaryTNode rootNode = new BinaryTNode(50, node1, node2);

            // binaryTree.root = rootNode;


            // foreach (var item in binaryTree.preOrder())
            // {
            //     Console.Write(item + " ");
            // }

            // ///// BST
            // Console.WriteLine("\n\nBST CLASS test code");

            // BSTree bsTree = new BSTree();

            // BinaryTNode rootNode2 = new BinaryTNode(50, null, null);

            //// bsTree.addRoot(rootNode2);

            // bsTree.add(50);
            // bsTree.add(52);
            // bsTree.add(55);

            // bsTree.add(15);
            // bsTree.add(20);
            // bsTree.add(23);

            // bsTree.add(51);
            // bsTree.add(30);
            // bsTree.add(53);
            // Console.WriteLine("is there 30 in the BSTree = "+bsTree.contains(30));
            // Console.WriteLine("is there 59 in the BSTree = " + bsTree.contains(59));
            #endregion
            #region call Class 17: tree-breadth-first
            //// add element to tree like image in README file(Tree DATA)

            //TreeNode node21 = new TreeNode(15);
            //TreeNode node12 = new TreeNode(5);
            //TreeNode node11 = new TreeNode(115);
            //TreeNode node2 = new TreeNode(10);
            //TreeNode node1 = new TreeNode(30);
            //TreeNode rootNode = new TreeNode(50);

            //rootNode.children.Add(node1);
            //rootNode.children.Add(node2);
            //node1.children.Add(node11);
            //node1.children.Add(node12);
            //node2.children.Add(node21);

            //List<int> listData = breadthFirst(rootNode);


            // Console.Write("[ ");

            //foreach (int item in listData)
            //{
            //    Console.Write(item + " ");
            //}

            //Console.WriteLine("]");


            #endregion
            #region Class 16: tree-max

            //BinaryTree binaryTree = new BinaryTree();

            /////// add element to tree like image in README file (Tree DATA)

            //BinaryTNode node21 = new BinaryTNode(15, null, null);
            //BinaryTNode node12 = new BinaryTNode(5, null, null);
            //BinaryTNode node11 = new BinaryTNode(115, null, null);
            //BinaryTNode node2 = new BinaryTNode(10, node21, null);
            //BinaryTNode node1 = new BinaryTNode(30, node11, node12);
            //BinaryTNode rootNode = new BinaryTNode(50, node1, node2);

            //binaryTree.root = rootNode;

            //Console.WriteLine("the max is " + binaryTree.findMaximum());


            #endregion
            #region Class 13: stack-queue-brackets

            //Console.WriteLine(validateBrackets("sds[]"));
            //Console.WriteLine(validateBrackets("{}(){}"));
            //Console.WriteLine(validateBrackets("()[[Extra Characters]]"));
            //Console.WriteLine(validateBrackets("{(})"));

            #endregion
            #region Class 12: stack-queue-animal-shelter

            // AnimalShelter animalShelter = new AnimalShelter();
            // Console.WriteLine(animalShelter.dequeue("cat"));
            // Cat cat = new Cat("cat1");
            // Cat cat2 = new Cat("cat2");
            // Dog dog = new Dog("dog1");
            // Cat cat5 = new Cat("cat5");





            // animalShelter.enqueue(cat);


            // animalShelter.enqueue(cat2);
            // animalShelter.enqueue(dog);
            // Console.WriteLine(animalShelter.dequeue("Lion"));
            //animalShelter.enqueue(cat5);



            // Console.WriteLine(animalShelter.dequeue("cat"));
            // Console.WriteLine(animalShelter.dequeue("cat"));

            #endregion
            #region Class 11: stack-queue-pseudo
            /////////////Class 11: stack-queue-pseudo



            //PseudoQueue pseudoqueue = new PseudoQueue();

            //pseudoqueue.enqueue("a");
            //Console.WriteLine("enqueue " + pseudoqueue.peek());

            //pseudoqueue.enqueue("b");
            //Console.WriteLine("enqueue b ");

            //pseudoqueue.enqueue("c");
            //Console.WriteLine("enqueue c \n");


            //Console.WriteLine("dequeue " + pseudoqueue.dequeue());

            //Console.WriteLine("dequeue " + pseudoqueue.dequeue());

            //Console.WriteLine("dequeue " + pseudoqueue.dequeue());

            //Console.WriteLine(pseudoqueue.peek());
            //pseudoqueue.enqueue("f");
            //Console.WriteLine(pseudoqueue.peek());
            //pseudoqueue.enqueue("b");
            //pseudoqueue.enqueue("c");
            //Console.WriteLine(pseudoqueue.peek());
            //Console.WriteLine(pseudoqueue.dequeue());
            //pseudoqueue.enqueue("d");
            //pseudoqueue.enqueue("e");
            //Console.WriteLine(pseudoqueue.dequeue());

            //Console.WriteLine(pseudoqueue.dequeue());

            //Console.WriteLine(pseudoqueue.dequeue());
            //Console.WriteLine("aaa "+pseudoqueue.peek());
            /////////////////////////////////////
            #endregion
            #region Class 10: Stack And Queue
            /////////////Class 10: Stack And Queue

            //Stack stack = new Stack();

            //Console.WriteLine(stack.peek());
            //Console.WriteLine(stack.pop());

            //stack.push("s");
            //Console.WriteLine(stack.peek());
            //Console.WriteLine(stack.pop());

            //if (stack.isEmpty())
            //{
            //    Console.WriteLine("stack is empty");
            //}


            //Queue queue = new Queue();

            //if (queue.isEmpty())
            //{
            //    Console.WriteLine("queue is empty");
            //}
            //queue.enqueue("a");
            //queue.enqueue("b");
            //queue.enqueue("c");
            //Console.WriteLine(queue.peek());
            //Console.WriteLine(queue.dequeue());

            //Console.WriteLine(queue.peek());
            //Console.WriteLine(queue.dequeue());
            //Console.WriteLine(queue.dequeue());
            //Console.WriteLine(queue.dequeue());
            /////////////////////////////////////
            #endregion
            #region Class8 methods  linked-list-zip
            ///////////Class8 methods  linked-list-zip
            //Console.WriteLine("List 1");

            //LinkedList list1 = new LinkedList();
            //list1.appendElement("a");
            //list1.appendElement("b");
            //list1.appendElement("c");

            //Console.WriteLine("\n List 2");

            //LinkedList list2 = new LinkedList();
            //list2.appendElement("x");
            //list2.appendElement("y");
            //list2.appendElement("z");


            //Console.WriteLine("\n Zip list1 and list2");
            //LinkedList list5 = zipList(list1, list2);

            //Console.WriteLine(list1.toString());
            //Console.WriteLine(list5.toString());
            //Console.WriteLine(list2.toString());

            /////////////////////////
            #endregion
            #region Class7 methods kthFromEndList

            ////////Class7 methods kthFromEndList

            //  Call_LinkedList3();

            //////////////////////////
            #endregion
            #region linked-list-insertions
            ////////// linked-list-insertions



            // Call_LinkedList2();

            ////////////////////

            #endregion
            #region linked-list Challenge

            /////////linked-list Challenge

            // Call_LinkedList();

            //////////////
            #region
            #endregion

            /////////array-reverse challenge           
            //String[] arrReverse = { "5", "6", "7" };
            ////  Class1.showArray(Class1.reverseArray(arrReverse));
            //Class1.ShowArray(Class1.ReversArray(arrReverse));

            ////////////////
            #endregion
            #region array-insert-shift challenge
            /////////////// array-insert-shift challenge
            //int[] arrinsertShift = { 1, 2, 3, 4 };

            //Console.WriteLine("the array after that we want to change it");
            //arrayIntElementToConsole(arrinsertShift);

            //int numInMiddel = 0;

            //do
            //{

            //    Console.WriteLine("Enter number to insert it in the middle");

            //} while (!int.TryParse(Console.ReadLine(), out numInMiddel));


            //int[] arrinsertShift02 = Class02.insertShiftArray(arrinsertShift, numInMiddel);
            //Console.WriteLine("the array after add number in the middle");
            //arrayIntElementToConsole(arrinsertShift02);

            //arrinsertShift02 = Class02.deleteShiftArray(arrinsertShift02);
            //Console.WriteLine("the array after delete number in the middle");
            //arrayIntElementToConsole(arrinsertShift02);

            /////////////////////////////////////////
            #endregion
            #region array-binary-search challenge
            ////////array-binary-search challenge

            //int[] binarySearch_arr = { 2, 3, 2, 7, 4, 6, 5 };


            //Console.WriteLine(Class3.BinarySearch(Class3.SortArray(binarySearch_arr), 9));
            //////////////////////////
            #endregion







            Console.ReadKey();


        }
    }
}
