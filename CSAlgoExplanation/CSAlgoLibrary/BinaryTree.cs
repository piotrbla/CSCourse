using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAlgoLibrary
{
    public class BinaryTree
    {
        public class Node
        {
            public int Value { get; set; }
            public Node? Left { get; set; } 
            public Node? Right { get; set; }
            public Node(int value)
            {
                Value = value;
                Left = null;
                Right = null;
            }
        }
        public int Count { get; set; }
        public Node? Root { get; set; }
        public BinaryTree()
        {
            Count = 0;
            Root = null;
        }
        public void AddNode(Node node, int value)
        {
            if (value < node.Value)
            {
                if (node.Left == null)
                    node.Left = new Node(value);
                else
                    AddNode(node.Left, value);
            }
            else
            {
                if (node.Right == null)
                    node.Right = new Node(value);
                else
                    AddNode(node.Right, value);
            }
        }
        public void Add(int v)
        {
            Count++;
            if (Root is null)
                Root = new Node(v);
            else
                AddNode(Root, v);

        }
    }
}
