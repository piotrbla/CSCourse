using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable enable
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
        private IEnumerable<int> GetInorder(Node? node)
        {
            if (node is null)
                yield break;
            foreach (var leftValue in GetInorder(node.Left))
            {
                yield return leftValue;
            }

            yield return node.Value;

            foreach (var rightValue in GetInorder(node.Right))
            {
                yield return rightValue;
            }


        }
        public IEnumerable<int> GetInorder()
        {
            return GetInorder(Root);
        }

        private IEnumerable<int> GetPostorder(Node? node)
        {
            if (node is null)
                yield break;
            foreach (var leftValue in GetPostorder(node.Left))
            {
                yield return leftValue;
            }
            foreach (var rightValue in GetPostorder(node.Right))
            {
                yield return rightValue;
            }
            yield return node.Value;
        }
        
        public IEnumerable<int> GetPostorder()
        {
            return GetPostorder(Root);
        }


        public IEnumerable<int> GetInorderStack()
        {
            if (Root is null)
                yield break;
            Stack<Node> stack = new Stack<Node>();
            Node? current = Root;
            while (current != null || stack.Count > 0)
            {
                while (current != null)
                {
                    stack.Push(current);
                    current = current.Left;
                }
                current = stack.Pop();
                yield return current.Value;
                current = current.Right;
            }
        }
        public IEnumerable<int> GetPreorder()
        {
            if (Root is null)
                yield break;
            Stack<Node> stack = new Stack<Node>();
            stack.Push(Root);
            while (stack.Count > 0)
            {
                Node current = stack.Pop();
                yield return current.Value;
                if (current.Right != null)
                    stack.Push(current.Right);
                if (current.Left != null)
                    stack.Push(current.Left);
            }
        }
    }
}
