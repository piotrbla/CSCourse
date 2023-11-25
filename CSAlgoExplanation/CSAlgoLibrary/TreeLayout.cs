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
            var result = new List<List<Point>>();
            if (rowCount == 0)
            {
                return result;
            }
            var mediumWidth = width / 2;
            var rowHeight = height / rowCount;
            var rowHeightHalf = rowHeight / 2;
            var row = new List<Point>();
            row.Add(new Point { X = mediumWidth, Y = rowHeightHalf });
            result.Add(row);

            var index = 1;
            var elementsInRow = 2;
            var notDrawnElement = elementsInRow - 1;
            var xStart = mediumWidth - (mediumWidth / 2);
            var xEnd = mediumWidth + (mediumWidth / 2);
            while (index < rowCount)
            {
                var nextRow = new List<Point>();
                var yCenter = index * rowHeight + rowHeightHalf;
                var rowWidth = xEnd - xStart;
                var xValue = xStart ;
                var xStep = rowWidth / elementsInRow;
                for (int i = 0; i <= elementsInRow; i++)
                {
                    if (i != notDrawnElement)
                        nextRow.Add(new Point
                        {
                            X = xValue,
                            Y = yCenter
                        });
                    xValue += xStep;
                }

                xStart /= 2;
                xEnd += xStart;
                index++;
                result.Add(nextRow);
                notDrawnElement = elementsInRow;
                elementsInRow *= 2;
            }

            return result;
        }

    }
}