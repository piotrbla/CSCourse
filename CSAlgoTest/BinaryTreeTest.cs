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
            Assert.Equal(6, tree.Root.Value);
        }

        [Fact]
        public void LeftIsLessThanRoot()
        {
            var tree = new CSAlgoLibrary.BinaryTree();
            tree.Add(6);
            tree.Add(2);
            Assert.Equal(2, tree.Count);
            Assert.Equal(6, tree.Root.Value);
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
            Assert.Equal(6, tree.Root.Value);
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
            Assert.Equal(6, tree.Root.Value);
            Assert.Equal(2, tree.Root.Left.Value);
            Assert.Equal(7, tree.Root.Right.Value);
            Assert.Equal(1, tree.Root.Left.Left.Value);
        }

    }
}
