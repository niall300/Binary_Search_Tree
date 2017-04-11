using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    public class Node
    {
        public int value;
        public Node right;
        public Node left;

        public Node(int data)
        {
            this.right = null;
            this.left = null;
            this.value = data;

        }
    }

    public class Tree
    {
        Node rootNode;

        public Tree()
        {
            rootNode = null;
        }

        public Tree(int input)
        {
            rootNode = new Node(input);
        }

        public void Add(int input)
        {
            //if rootnode is null add new node
            if(rootNode == null)
            {
                rootNode = new Node(input);
            }
            //otherwise check if value is less than
            //rootnode
            //call method again on rootnode.left
            else if(input < rootNode.value)
            {
                rootNode = rootNode.left;

            }
            else
            {
                rootNode = rootNode.left;
            }


            //else if value is greater
            //call methos again on rootNode.right

        }

        //if we traverse left to right
        //we end up with a sorted collection
        public void TraverseSorted()
        {

        }
       

        public void PrintSorted()
        {
            if(rootNode.left != null)
            {
                //keep going left
                //until we find null
                rootNode = rootNode.left;
                PrintSorted();
            }
            if(rootNode.left == null)
            {
                //once we get to the end print node
                Console.WriteLine(rootNode.value);

                //and move right
                rootNode = rootNode.right;
                PrintSorted();
            }


            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
