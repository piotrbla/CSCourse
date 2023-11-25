namespace CSAlgoTest
{
    public class TreeLayoutTest
    {
        const int width = 3000;
        const int height = 2000;
        [Fact]
        public void EmptyListWhenZeroElement()
        {

        }

        [Fact]
        public void OneRowHas1Element()
        {
            var layout = CSAlgoLibrary.TreeLayout.GetLayout(1, width, height);
            Assert.Single(layout);
        }

        [Fact]
        public void TwoRowsHas3Elements()
        {
            var layout = CSAlgoLibrary.TreeLayout.GetLayout(2, width, height);
            Assert.Equal(2, layout.Count);
            int elementscount = layout.Sum(l => l.Distinct().Count());
            Assert.Equal(3, elementscount);
        }

        [Fact]
        public void ThreeRowsHas7Elements()
        {
            var layout = CSAlgoLibrary.TreeLayout.GetLayout(3, width, height);
            Assert.Equal(3, layout.Count);
            int elementscount = layout.Sum(l => l.Distinct().Count());
            Assert.Equal(7, elementscount);
        }
        [Fact]
        public void SevenRowsHas127Elements()
        {
            var layout = CSAlgoLibrary.TreeLayout.GetLayout(7, width, height);
            Assert.Equal(7, layout.Count);
            int elementscount = layout.Sum(l => l.Distinct().Count());
            Assert.Equal(127, elementscount);
        }
    }
}