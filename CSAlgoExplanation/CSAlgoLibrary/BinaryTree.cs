using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable enable
namespace CSAlgoLibrary
{
    public class BinaryTree<T>
    {

 
        public class Node // <T>
        {
            public T Value { get; set; }
            public Node? Left { get; set; }
            public Node? Right { get; set; }
            public Node(T value)
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
        public void AddNode(Node node, T value)
        {
            if (Comparer<T>.Default.Compare(value, node.Value) < 0)
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
        public void Add(T v)
        {
            Count++;
            if (Root is null)
                Root = new Node(v);
            else
                AddNode(Root, v);

        }
        private IEnumerable<T> GetInorder(Node? node)
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
        public IEnumerable<T> GetInorder()
        {
            return GetInorder(Root);
        }

        private IEnumerable<T> GetPostorder(Node? node)
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
        
        public IEnumerable<T> GetPostorder()
        {
            return GetPostorder(Root);
        }


        [Obsolete("Don't use GetInorderStack, use GetInorder instead", true)]
        public IEnumerable<T> GetInorderStack()
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
        public IEnumerable<T> GetPreorder()
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
