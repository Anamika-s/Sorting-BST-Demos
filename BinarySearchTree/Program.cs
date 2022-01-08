using System;

namespace ConsoleApp1
{
    class Node
    {
        public int Data;
        public Node Left;
        public Node Right;
        public void Display()
        {
            Console.WriteLine(Data + "->");
        }
    }
    class BinarySearchTree
    {
        public Node root;
        public BinarySearchTree()
        {
            root = null;
        }
        public void Insert(int data)
        {
            Node newNode = new Node();
            
            newNode.Data = data;
            if (root == null)
            {
                root = new Node();
                root = newNode;
                Console.WriteLine("Root Node added");
            }
            else { 
                Node ptr=root;
            Node parent;
                while (true)
                {
                    parent = ptr;
                    if (data < ptr.Data)
                    {
                        ptr = ptr.Left;
                        if (ptr == null)
                        {
                            parent.Left = newNode;
                            Console.WriteLine("Added at left");
                            break;
                        }
                    }
                    else
                    {
                        ptr = ptr.Right;
                        if (ptr == null)
                        {
                            parent.Right = newNode;
                            Console.WriteLine("Added at right");
                            break;
                        }
                    }
                    }
                }
            }
        // Left Root Right
        public void InOrderTraversal(Node parent)
        {
              if(parent!=null)
            {
                InOrderTraversal(parent.Left);
                Console.WriteLine(parent.Data);
                InOrderTraversal(parent.Right);
            }

        }
        public void PreOrderTraversal(Node parent)
        {
            if (parent != null)
            {
                Console.WriteLine(parent.Data);
                PreOrderTraversal(parent.Left);

                PreOrderTraversal(parent.Right);
            }

        }
        public void PostOrderTraversal(Node parent)
        {
            if (parent != null)
            {

                PostOrderTraversal(parent.Left);

                PostOrderTraversal(parent.Right);
                Console.WriteLine(parent.Data);
            }

        }
    }
    

    
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree searchTree = new BinarySearchTree();
            searchTree.Insert(10);
            searchTree.Insert(12);
            searchTree.Insert(15);
            searchTree.Insert(5);
            searchTree.Insert(7);
            Console.WriteLine("InOrder");
            searchTree.InOrderTraversal(searchTree.root);
            Console.WriteLine("PreOrder");
            searchTree.PreOrderTraversal(searchTree.root);
            Console.WriteLine("PostOrders");
            searchTree.PostOrderTraversal(searchTree.root);



        }
    }
}
