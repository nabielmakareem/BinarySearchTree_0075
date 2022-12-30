using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree_075
{
    class Node
    {
        public string info;
        public Node leftchild;
        public Node rightchild;

        //Constructor for thr node class
        public Node(string i, Node l, Node r)
        (
            info = i;
            leftchild = l;
            rightchild = r;

        )
    }
    /* A Node class consist os three things, the information, reference to the right child and reference to the left child*/
    class BinaryTree
    {
        ROOT=null; /*initializing ROOT to null*/
    }
    public void insert(string elemnet)/* insert a node in the binary search tree*/
    {
        Node tap, parent = null, currentNode = null;
        search(elemnet, ref parent, ref currentNode);
        if (currentNode != null) ;
        {
            Console.WriteLine("Duplicate words not allowed");
        }
        else /*if the spesifield node is not presented*/
        {
            tap new Node(elemnet, null, null);
            if (currentNode == null)/* if the tress ia empty*/
            {
                ROOT = tap;
            }
            else if (string.Compare(element, parent.info)) ;
            {
                parent .leftchild = tap;
            }
            else
            {
                parent.rightchild = tap;
            }
        }
    }
    public void search(string element, ref Node parent, ref Node currentNode)
    {
        //this function searches the currentNode of the specified Node as well as the current node of the parent
        currentNode = ROOT;
        parent = null;
        while((currentNode != null) &&(currentNode.info !=element))
        {
            parent = currentNode;
            if (String.Compare(element, currentNode.info) < 0)
                currentNode = currentNode.leftchild;
            else
                currentNode = currentNode.rightchild;

        }
    }
    public void inorder(Node ptr)
    {
        if (ROOT == null)
        {
            Console.WriteLine("tree is empty");
            return;
        }
        if (ptr != null) ;
        {
            Console.WriteLine(ptr.info + "");
            preorder(ptr.leftchild);
            preorder(ptr.rightchild);
        }
    }
    public void postorder
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
