﻿using System;
using System.Collections.Generic;
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
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}