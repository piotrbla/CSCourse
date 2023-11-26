namespace CSAlgoLibrary
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    public class TreeLayout
    {
        
        public static List<List<Point>> GetLayout(int rowCount, int width, int height)
        {
            var widthMargin = 40;
            var result = new List<List<Point>>();
            if (rowCount == 0)
            {
                return result;
            }
            for (int i = 0; i < rowCount; i++)
            {
                var row = new List<Point>();
                result.Add(row);
            }
            var mediumWidth = width / 2;
            var rowHeight = height / rowCount;
            var rowHeightHalf = rowHeight / 2;
            result[0].Add(new Point { X = mediumWidth, Y = rowHeightHalf });

            var index = rowCount - 1;
            var elementsInRow = Math.Pow(2, index);
            var xStart = widthMargin;
            var xEnd = width - widthMargin;
            var elementWidth = (xEnd - xStart) / (elementsInRow - 1);

            while (index>0)
            {
                var yCenter = rowHeight * index + rowHeightHalf;
                var xValue = xStart;
                elementWidth = (xEnd - xStart) / (elementsInRow - 1);
                for (int i = 0; i < elementsInRow; i++)
                {
                    result[index].Add(new Point { X = xValue, Y = yCenter });
                    xValue += (int)elementWidth;
                }


                elementsInRow /= 2;
                xStart += (int)elementWidth / 2;
                xEnd -= (int)elementWidth / 2;
                index--;
            }
            return result;
        }

    }
}