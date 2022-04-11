using System.Text;

namespace Patterns.Strategy
{
    internal class BubbleSort : ISorting
    {
        public string Sort(int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int tmp = array[j];

                        array[j] = array[j + 1];

                        array[j + 1] = tmp;

                    }
                }
            }

            StringBuilder builder = new StringBuilder();

            foreach(var item in array)
            {
                builder.Append(item.ToString());
            }

            return builder.ToString();
        }
    }
}
