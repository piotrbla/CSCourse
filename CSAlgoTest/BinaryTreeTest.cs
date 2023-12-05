using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAlgoTest
{
    public class BinaryTreeTest
    {
        [Fact]
        public void EmptyTreeWhenZeroElement()
        {
            var tree = new CSAlgoLibrary.BinaryTree();
            Assert.Equal(0, tree.Count);
        }

        [Fact]
        public void TreeHasCount1WhenOneElement()
        {
            var tree = new CSAlgoLibrary.BinaryTree();
            tree.Add(1);
            Assert.Equal(1, tree.Count);
        }

        [Fact]
        public void RootIsEqualtoAddedValue()
        {
            var tree = new CSAlgoLibrary.BinaryTree();
            tree.Add(6);
            Assert.Equal(1, tree.Count);
            Assert.NotNull(tree.Root);
            Assert.Equal(6, tree.Root.Value);
        }

        [Fact]
        public void LeftIsLessThanRoot()
        {
            var tree = new CSAlgoLibrary.BinaryTree();
            tree.Add(6);
            tree.Add(2);
            Assert.Equal(2, tree.Count);
            Assert.NotNull(tree.Root);
            Assert.Equal(6, tree.Root.Value);
            Assert.NotNull(tree.Root.Left);
            Assert.Equal(2, tree.Root.Left.Value);
        }

        [Fact]
        public void RightIsGreaterThanRoot()
        {
            var tree = new CSAlgoLibrary.BinaryTree();
            tree.Add(6);
            tree.Add(2);
            tree.Add(7);
            Assert.Equal(3, tree.Count);
            Assert.NotNull(tree.Root);
            Assert.Equal(6, tree.Root.Value);
            Assert.NotNull(tree.Root.Right);
            Assert.NotNull(tree.Root.Left);
            Assert.Equal(2, tree.Root.Left.Value);
            Assert.Equal(7, tree.Root.Right.Value);
        }

        [Fact]
        public void LeftLeftIsLessThanRoot()
        {
            var tree = new CSAlgoLibrary.BinaryTree();
            tree.Add(6);
            tree.Add(2);
            tree.Add(7);
            tree.Add(1);
            Assert.Equal(4, tree.Count);
            Assert.NotNull(tree.Root);
            Assert.Equal(6, tree.Root.Value);
            Assert.NotNull(tree.Root.Left);
            Assert.Equal(2, tree.Root.Left.Value);
            Assert.NotNull(tree.Root.Right);
            Assert.Equal(7, tree.Root.Right.Value);
            Assert.NotNull(tree.Root.Left.Left);
            Assert.Equal(1, tree.Root.Left.Left.Value);
        }
        [Fact]
        public void InorderHas2467Order()
        {
            var tree = new CSAlgoLibrary.BinaryTree();
            tree.Add(6);
            tree.Add(2);
            tree.Add(7);
            tree.Add(4);
            Assert.Equal(4, tree.Count);
            Assert.NotNull(tree.Root);
            Assert.Equal(6, tree.Root.Value);
            string order = string.Join("", tree.GetInorder());
            Assert.Equal("2467", order);
        }

        [Fact]
        public void InorderHas123467Order()
        {
            var tree = new CSAlgoLibrary.BinaryTree();
            tree.Add(6);
            tree.Add(2);
            tree.Add(7);
            tree.Add(4);
            tree.Add(1);
            tree.Add(3);
            Assert.Equal(6, tree.Count);
            Assert.NotNull(tree.Root);
            Assert.Equal(6, tree.Root.Value);
            string order = string.Join("", tree.GetInorder());
            Assert.Equal("123467", order);
        }
        [Fact]
        public void PreorderHas6247Order()
        {
            var tree = new CSAlgoLibrary.BinaryTree();
            tree.Add(6);
            tree.Add(2);
            tree.Add(7);
            tree.Add(4);
            Assert.Equal(4, tree.Count);
            Assert.NotNull(tree.Root);
            Assert.Equal(6, tree.Root.Value);
            string order = string.Join("", tree.GetPreorder());
            Assert.Equal("6247", order);
        }

        [Fact]
        public void InorderHas1to8Order()
        {
            var tree = new CSAlgoLibrary.BinaryTree();
            tree.Add(6);
            tree.Add(2);
            tree.Add(7);
            tree.Add(4);
            tree.Add(1);
            tree.Add(3);
            tree.Add(8);
            tree.Add(5);
            Assert.Equal(8, tree.Count);
            Assert.NotNull(tree.Root);
            Assert.Equal(6, tree.Root.Value);
            string order = string.Join("", tree.GetInorder());
            Assert.Equal("12345678", order);
        }
        [Fact]
        public  void PostOrderHas1to6Order()
        {
            var tree = new CSAlgoLibrary.BinaryTree();
            tree.Add(6);
            tree.Add(2);
            tree.Add(7);
            tree.Add(4);
            tree.Add(1);
            tree.Add(3);
            tree.Add(5);
            tree.Add(9);
            tree.Add(8);
            Assert.Equal(9, tree.Count);
            Assert.NotNull(tree.Root);
            Assert.Equal(6, tree.Root.Value);
            string order = string.Join("", tree.GetPostorder());
            Assert.Equal("135428976", order);
        }

    }
}
