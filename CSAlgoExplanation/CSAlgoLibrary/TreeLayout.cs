namespace CSAlgoLibrary
{
    public class TreeLayout
    {
        public static List<List<int>> GetLayout(int[] input)
        {
            var result = new List<List<int>>();
            if (input.Length == 0)
            {
                return result;
            }

            var row = new List<int>();
            row.Add(input[0]);
            result.Add(row);

            var index = 1;
            while (index < input.Length)
            {
                var nextRow = new List<int>();
                for (var i = 0; i < result[result.Count - 1].Count * 2; i++)
                {
                    if (index >= input.Length)
                    {
                        break;
                    }

                    nextRow.Add(input[index]);
                    index++;
                }

                result.Add(nextRow);
            }

            return result;
        }

    }
}